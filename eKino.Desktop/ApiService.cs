using eKino.Desktop.Properties;
using Flurl;
using Flurl.Http;
using Flurl.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eKino.WinUI
{
    public class ApiService
    {
        private readonly string _route = null;
        public ApiService(string route)
        {
            _route = route; 
        }

        public void Add<T>(T x)
        {
            $"{Settings.Default.ApiUrl}/{_route}".PostJsonAsync(x);
        }

        public T Get<T>()
        {
            var result = $"{Settings.Default.ApiUrl}/{_route}".GetJsonAsync<T>();

            return result.Result;
        }

        public async Task<T> GetByIme<T>(string ime)
        {
            var result = $"{Settings.Default.ApiUrl}/{_route}/PoImenu/{ime}";
            return await result.GetJsonAsync<T>();
        }
        
        public T GetByName<T>(string naziv)
        {
            var result = $"{Settings.Default.ApiUrl}/{_route}/PoNazivu/{naziv}".GetJsonAsync<T>();
            return result.Result;
        }
    }
}
