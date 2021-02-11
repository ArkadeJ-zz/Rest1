using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Restaurants.Models
{
    public class Restaurants
    {
        public int Rank { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Rest { get; set; }
        public string Dish { get; set; }
        [Required]
        [RegularExpression(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}",  ErrorMessage = "Phone number entered incorrectly, please use this format: 000-000-0000")]
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Site { get; set; }



        public static Restaurants[] GetRestaurants()
        {
            Restaurants r1 = new Restaurants
            {
                Rank = 1,
                Name = "Kaden",
                Rest = "Tucanos",
                Dish = "Picaña",
                Phone = "8012244774",
                Address = "545 E University Pkwy, Provo, UT 84097",
                Site = "www.tucanos.com",

            };

            Restaurants r2 = new Restaurants
            {
                Rank = 2,
                Name = "Kaden",
                Rest = "Texas Roadhouse",
                Dish = "Chicken Critters",
                Phone = "8012262742",
                Address = "1265 S State St, Provo, UT 84097-7033",
                Site = "www.texasroadhouse.com",

            };

            Restaurants r3 = new Restaurants
            {
                Rank = 3,
                Name = "Kaden",
                Rest = "Red Robin",
                Dish = "Whiskey Burger",
                Phone = "8018528093",
                Address = "1200 Towne Centre Blvd, Unit 1100, Provo, UT 84601,",
                Site = "www.redrobin.com",
            };

            Restaurants r4 = new Restaurants
            {
                Rank = 4,
                Name = "Kaden",
                Rest = "Brazas",
                Dish = "Tacos Al Pastor",
                Phone = "8013750240",
                Address = "238 W 100 S St, Provo, UT 84601, United States",
                Site = "www.lasbrazasmexicangrill.com",

            };

            Restaurants r5 = new Restaurants
            {
                Rank = 5,
                Name = "Kaden",
                Rest = "BumbleBees BBQ",
                Dish = "Kpop Fries",
                Phone = "8016072543",
                Address = "1254 N State St, Provo, UT 84604-6432",
                Site = "www.bumblebeeskbbq.com",

            };

            return new Restaurants[] { r1, r2, r3, r4, r5 };
        }
    }
}
