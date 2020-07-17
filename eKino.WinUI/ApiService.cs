using Flurl;
using Flurl.Http;
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

        public T Get<T>()
        {
            var result = $"{Properties.Resources.ApiUrl}/{_route}".GetJsonAsync<T>();

            return result.Result;
        }
    }
}
