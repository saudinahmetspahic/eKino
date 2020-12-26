using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.API.EF
{
    public class Data
    {
        public static void Seed(MojContext context)
        {
            context.Database.Migrate();
        }
    }
}
