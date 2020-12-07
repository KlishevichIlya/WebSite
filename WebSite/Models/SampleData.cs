using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class SampleData
    {

        public static async Task InitializeAsync(CarContext context)
        {
            /*if (!await context.Orders.AnyAsync())
            {
                await context.Orders.AddRangeAsync(
                        new Order
                        {
                            UserName = "Toxa",
                            Address = "Moscow str. Arbet 14-12",
                            ContactPhone = "+79027654799",
                            OrederDate = DateTime.Now,
                            User = await context.Users.FirstOrDefaultAsync(p => p.UserId == 2)

                        }
                    );
                await context.SaveChangesAsync();

            }*/

            if (!await context.Cars.AnyAsync())
            {
                await context.Cars.AddRangeAsync(
                    new Car
                    {
                        Model = "Tesla Model X",
                        Country = "USA",
                        Price = "100000$",
                        Color = "White",
                        isNew = true,
                        img = "/images/tesla.jpg"
                    },
                    new Car
                    {
                        Model = "Nissan GTR R34",
                        Country = "Japan",
                        Price = "70000$",
                        Color = "Blue",
                        isNew = false
                    }
                    );
                await context.SaveChangesAsync();
            }

            if (!await context.Users.AnyAsync())
            {
                await context.Users.AddRangeAsync(
                    new User
                    {
                        FirstName = "Bob",
                        SecondName = "Smith",
                        Age = 38,
                        Address = "NY str.Square 3-12",
                        isVIP = false
                    },
                    new User
                    {
                        FirstName = "Anton",
                        SecondName = "Petrov",
                        Age = 23,
                        Address = "Mow str. Arbet 14-12",
                        isVIP = true

                    }
                    );
                await context.SaveChangesAsync();
            }


            /*if (! await context.DescriotionCars.AnyAsync())
            {
                await context.DescriotionCars.AddRangeAsync(
                    new DescriotionCar
                    {

                    }
                    );
            }*/
            


        }
    }
}
