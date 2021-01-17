using eKino.Model;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eKino.Mobile
{
    public class ApiService
    {
        public static string Email;
        public static string Sifra;

#if DEBUG
        private readonly string _apiUrl = "http://10.0.2.2:5000/api"; 
#endif
#if RELEASE
        private readonly string _apiUrl = "http://myapp.com/api";
#endif
        private readonly string _route = null;
        public ApiService(string route)
        {
            _route = route;
        }

        public T Add<T>(T x)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}";

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
                Application.Current.MainPage.DisplayAlert("Upozorenje", stringBuilder.ToString(), "Ok");
                return default(T);
            }
        }

        public T Get<T>(object search = null, bool auth = true) // async pravi probleme
        {
            try
            {
                var s = $"{_apiUrl}/{_route}";
                if (search != null)
                {
                    s += "?";
                    s += search.ToQueryString();
                }


                Task<T> result;
                if (auth)
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
                    Application.Current.MainPage.DisplayAlert("Upozorenje", "Pogrešan email ili sifra", "Ok");
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    Application.Current.MainPage.DisplayAlert("Upozorenje", "Zabranjen pristup.", "Ok");
                }
                throw;
            }
            //catch (Exception ex)
            //{
            //    Application.Current.MainPage.DisplayAlert("Upozorenje", "Nepoznata greska: " + ex.Message, "Ok");
            //    throw;
            //}
        }

        //public T GetById<T>(int Id)
        //{
        //    var result = $"{_apiUrl}/{_route}/{Id}";
        //    return result.WithBasicAuth(Email, Sifra).GetJsonAsync<T>().Result;
        //}

        public T Update<T>(int id, object request)
        {
            try
            {
                var s = $"{_apiUrl}/{_route}/{id}";

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

                Application.Current.MainPage.DisplayAlert("Greska", stringBuilder.ToString(), "Ok"); 
                return default(T);
            }

        }

        //public T GetByName<T>(string naziv)
        //{
        //    var result = $"{_apiUrl}/{_route}/PoNazivu/{naziv}";
        //    return result.WithBasicAuth(Email, Sifra).GetJsonAsync<T>().Result;
        //}

        public void Remove(int Id)
        {
            $"{_apiUrl}/{_route}/{Id}".WithBasicAuth(Email, Sifra).DeleteAsync();
        }

    }
}
