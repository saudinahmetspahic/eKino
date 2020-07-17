using eKino.Desktop.Properties;
using Flurl;
using Flurl.Http;
using Flurl.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.WinUI
{
    public class ApiService
    {
        private readonly string _route = null;
        public ApiService(string route)
        {
            _route = route; 
        }

        public bool Add<T>(T x)
        {
            var result = $"{Settings.Default.ApiUrl}/{_route}".PostJsonAsync(x);
            return result.IsCompleted;
        }

        public T Get<T>()
        {
            var result = $"{Settings.Default.ApiUrl}/{_route}".GetJsonAsync<T>();

            return result.Result;
        }

        public T GetByName<T>(string naziv)
        {
            var result = $"{Settings.Default.ApiUrl}/{_route}/PoNazivu/{naziv}".GetJsonAsync<T>();
            return result.Result;
        }
    }
}
