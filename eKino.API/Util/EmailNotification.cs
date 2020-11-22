using eKino.API.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;

namespace eKino.API.Util
{
    public class EmailNotification : BackgroundService
    {
        private HttpClient _client;
        private IServiceScopeFactory _serviceScopeFactory { get; set; }

        public EmailNotification(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _client = new HttpClient();
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _client.Dispose();
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await Task.Delay(20000);
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetService<MojContext>();
                while (!stoppingToken.IsCancellationRequested)
                {
                    try
                    {
                        var s = await _client.GetAsync("http://127.0.0.1:5000/api/Korisnik");
                        if (s.StatusCode != HttpStatusCode.NotFound)
                        {
                            var projekcije = db.Projekcija.Where(w => w.DatumProjekcije.CompareTo(DateTime.Now) > 0 && w.DatumProjekcije.AddDays(-1).CompareTo(DateTime.Now) < 0).ToList();
                            foreach (var p in projekcije)
                            {
                                var rezr = db.Rezervacija.Include(i => i.Kupac).Where(w => w.ProjekcijaId == p.Id && w.Kupac.SlanjeEmaila == true).ToList();
                                var rezervacije = rezr.GroupBy(g => g.Kupac);

                                foreach (var rez in rezervacije)
                                {
                                    var sadrzaj = "** Projekcije filmova za koje imate rezrvacije se održavaju u naredna 24 sata **\nDATUM PROJEKCIJE " + p.DatumProjekcije + "\nOPIS PROJEKCIJE: " + p.Opis + "\nREZERVACIJE (" + rez.Count() + "):\n";
                                    foreach (var r in rez)
                                    {
                                        sadrzaj += "Sjedište: " + r.SjedisteRed + "/" + r.SjedisteKolona + "\n";
                                    }

                                    await SendEmail(rez.Key.Email, "E-KINO PORJEKCIJA", sadrzaj);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        await Task.Delay(5000, stoppingToken);
                    }

                    await Task.Delay(3600000 * 3, stoppingToken); // 3600000 ms = 1 h
                }
                db.Dispose();
            }



        }

        private async Task SendEmail(string za, string naslov, string sadrzaj)
        {
            MailMessage poruka = new MailMessage("app_alarm@hotmail.com", za);
            poruka.Subject = naslov;
            poruka.Body = sadrzaj;
            poruka.IsBodyHtml = false;

            SmtpClient c = new SmtpClient();
            c.Host = "smtp.office365.com";
            c.Port = 587;
            c.EnableSsl = true;

            NetworkCredential nc = new NetworkCredential("app_alarm@hotmail.com", "Alarm12345");
            c.Credentials = nc;
            await c.SendMailAsync(poruka);
        }
    }
}
