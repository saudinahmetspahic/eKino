using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Model.Requests
{
    public class ProdukcijskaKucaInsertRequest
    {
        public string Naziv { get; set; }
        public int? GradId { get; set; }
    }
}
