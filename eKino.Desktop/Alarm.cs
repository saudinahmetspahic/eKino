using eKino.Model;
using eKino.Model.Requests;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eKino.Desktop
{
    public class Alarm : BackgroundService
    {
        private HttpClient client { get; set; }
        //private IServiceScopeFactory _serviceScopeFactory { get; set; }
        public Alarm(/*IServiceScopeFactory serviceScopeFactory*/)
        {
            //_serviceScopeFactory = serviceScopeFactory;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            client = new HttpClient();
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            client.Dispose();
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //using (var scope = _serviceScopeFactory.CreateScope())
            //{
                //var api = scope.ServiceProvider.GetService<ApiService>();
                var _korisnikApiService = new ApiService("Korisnik");
                var _rezervacijeApiService = new ApiService("Rezervacija");
                var _projekcijaApiService = new ApiService("Projekcija");
                while (!stoppingToken.IsCancellationRequested)
                {
                    try
                    {
                        var con = await client.GetAsync("/");
                        if (con.IsSuccessStatusCode)
                        {
                            var k = _korisnikApiService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault();
                            var rezervacije = _rezervacijeApiService.Get<List<Rezervacija>>(new RezervacijaSearchRequest { KorisnikId = k.Id });

                            string mail = "* Rezeracije \n";
                            int count = 0;
                            foreach (var r in rezervacije)
                            {
                                var p = _projekcijaApiService.GetById<Projekcija>((int)r.ProjekcijaId);
                                if (p.DatumProjekcije.AddHours(24).CompareTo(DateTime.Now) >= 0)
                                {
                                    mail += " ["  + p.DatumProjekcije + "] " + p.Opis + "\n";
                                    count++;
                                }
                            }

                            var smtpClient = new SmtpClient("app_alarm@hotmail.com")
                            {
                                Port = 587,
                                Credentials = new NetworkCredential("app_alarm@hotmail.com", "Alarm12345"),
                                EnableSsl = true,
                            };
                            smtpClient.Send("app_alarm@hotmail.com", k.Email, count + " projekcija u naredna 24 sata", mail);
                        }
                    }
                    catch (Exception)
                    {
                        await Task.Delay(10000, stoppingToken);
                    }

                    await Task.Delay(20000, stoppingToken); // 1h = 3600000
                }
            //}
        }
    }
}
