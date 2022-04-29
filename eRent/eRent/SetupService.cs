using eRent.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent
{
    public class SetupService
    {
        public static void Seed(MobisContext context)
        {
            context.Database.Migrate();
        }
    }
}
