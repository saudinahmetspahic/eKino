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
using System.Xml.Schema;

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

        public T Add<T>(T x)
        {

            try
            {
                var url = $"{Properties.Settings.Default.ApiUrl}/{_route}";

                var result = url.WithBasicAuth(Email, Sifra).PostJsonAsync(x).ReceiveJson<T>();

                return result.Result;
            }
            catch (FlurlHttpException ex)
            {
                var errors = ex.GetResponseJsonAsync<Dictionary<string, string[]>>().Result;

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }
                MessageBox.Show(stringBuilder.ToString(), "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return default(T);
            }
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

                var r = result.Result;
                return r;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Pogresan email ili sifra.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Zabranjen pristup.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                throw;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nepoznata greska", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public T GetById<T>(int Id)
        {
            var result = $"{Settings.Default.ApiUrl}/{_route}/{Id}";
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

        public void Remove(int Id)
        {
            $"{Settings.Default.ApiUrl}/{_route}/{Id}".WithBasicAuth(Email, Sifra).DeleteAsync();
        }
    }
}
