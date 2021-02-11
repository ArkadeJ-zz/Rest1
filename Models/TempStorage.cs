using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants.Models
{
    public class TempStorage
    {
        private static List<Restaurants> Database = new List<Restaurants>();

        public static IEnumerable<Restaurants> Foods => Database;

        public static void Form(Restaurants eats)
        {
            Database.Add(eats);
        }
    }
}
