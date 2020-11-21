using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using eKino.Model;
using eKino.Model.Requests;
using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eKino.Mobile
{
    [Service]
    public class NotificationSender : Service
    {
        private ApiService _korisnikApiService = new ApiService("Korisnik");
        private ApiService _rezervacijeApiService = new ApiService("Rezervacija");
        private ApiService _projekcijaApiService = new ApiService("Projekcija");


        public override IBinder OnBind(Intent intent)
        {
            throw new NotImplementedException();
        }

        [return: GeneratedEnum]
        public override StartCommandResult OnStartCommand(Intent intent, [GeneratedEnum] StartCommandFlags flags, int startId)
        {
            Device.StartTimer(TimeSpan.FromDays(1), () =>
            {
                Alarm_Timer();

                return true; // True = Repeat again, False = Stop the timer
            });
            return base.OnStartCommand(intent, flags, startId);
        }

        private async void Alarm_Timer()
        {
            try
            {
                if (string.IsNullOrEmpty(ApiService.Email))
                    return;
                var k = _korisnikApiService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault();
                var rezervacije = _rezervacijeApiService.Get<List<Rezervacija>>(new RezervacijaSearchRequest { KorisnikId = k.Id });

                string mail = "* Rezeracije \n";
                int count = 0;
                foreach (var r in rezervacije)
                {
                    var p = _projekcijaApiService.GetById<Projekcija>((int)r.ProjekcijaId);
                    if (p.DatumProjekcije.AddHours(24).CompareTo(DateTime.Now) >= 0)
                    {
                        mail += " [" + p.DatumProjekcije + "] " + p.Opis + "\n";
                        count++;
                    } 
                }
                if(count > 0)
                    await SendEmail(k.Email, count + " projekcija u naredna 24 sata", mail);
            }
            catch (Exception)
            {
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
