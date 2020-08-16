using eKino.Desktop.Properties;
using eKino.Model;
using Flurl;
using Flurl.Http;
using Flurl.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace eKino.Desktop
{
    public class ApiService
    {
        public static string Email;
        public static string Sifra;

        private readonly string _route = null;
        public ApiService(string route)
        {
            _route = route;
        }

        public void Add<T>(T x)
        {
            $"{Settings.Default.ApiUrl}/{_route}".WithBasicAuth(Email, Sifra).PostJsonAsync(x);
        }

        public T Get<T>(object search = null, bool auth = true) // async pravi probleme
        {
            try
            {
                var s = $"{Settings.Default.ApiUrl}/{_route}";
                if(search != null)
                {
                    s += "?";
                    s += search.ToQueryString();
                } 

                Task<T> result;
                if(auth)
                    result = s.WithBasicAuth(Email, Sifra).GetJsonAsync<T>();
                else
                    result = s.GetJsonAsync<T>();

                return result.Result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Wrong username or password.", "Warining", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Forbidden.", "Warining", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                throw;
            }
        }

        public T GetById<T>(int Id)
        {
            var result = $"{Settings.Default.ApiUrl}/{_route}/Id/{Id}";
            return result.WithBasicAuth(Email, Sifra).GetJsonAsync<T>().Result;
        }

        public T Update<T>(int id, object request)
        {
            try
            {
                var s = $"{Settings.Default.ApiUrl}/{_route}/{id}";

                var result = s.WithBasicAuth(Email, Sifra).PutJsonAsync(request).ReceiveJson<T>();
                return result.Result;
            }
            catch (FlurlHttpException ex)
            {
                var errors = ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors.Result)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }

        public T GetByName<T>(string naziv)
        {
            var result = $"{Settings.Default.ApiUrl}/{_route}/PoNazivu/{naziv}";
            return result.WithBasicAuth(Email, Sifra).GetJsonAsync<T>().Result;
        }
    }
}
