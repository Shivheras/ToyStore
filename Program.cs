using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyStore.Models;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toy Store");
            Console.WriteLine("Choose Your Catagories");
            Console.WriteLine("1. Customers");
            Console.WriteLine("2.Toys Details");
            Console.WriteLine("3.Admin");
            Console.WriteLine("4.Promocodes");
            Console.WriteLine("5.Orders");
            string caseSwitch = Console.ReadLine();
            switch (caseSwitch)
            {
                case "1":
                   
                    Console.WriteLine("Customer Profile");
                    Console.WriteLine("1.Add CustomerDetails");
                    Console.WriteLine("2.Add Addresses");
                    Console.WriteLine("3.Get Addresses");
                    string caseString2 = Console.ReadLine();
                    switch (caseString2)
                    {
                        case "1":
                            addCustomer();
                            break;
                        case "2":
                            addAddress();
                            break;
                        case "3":
                            getAddress();
                            break;
                       
                        default:
                            Console.WriteLine("Value didn’t match earlier.");
                            break;
                    }
                    //Console.WriteLine("Case 1");
                    break;
                case "2":
                    Console.WriteLine("ToysDetails");
                    getToy();
                    break;
                case "3":
                    Console.WriteLine("Admin");
                    Console.WriteLine("1.Admin");
                    Console.WriteLine("2.Toys");
                    Console.WriteLine("3.Plants");
                    Console.WriteLine("4.Promocodes");
                    string caseString4 = Console.ReadLine();
                    switch (caseString4)
                    {
                        case "1":
                            Console.WriteLine("1.Add Admin");
                            Console.WriteLine("2.Remove Admin");
                            Console.WriteLine("2.List of Admin");
                            string admin = Console.ReadLine();
                            switch (caseString4)
                            {
                                case "1":
                                    addAdmin();
                             
                                    break;
                                case "2":
                                    removedeAdmin();
                               
                                    break;
                                case "3":
                                    getAdmin();
                                 
                                    break;
                                default:
                                    Console.WriteLine("Value didn’t match earlier.");
                                    break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("1.Add Toys");
                            Console.WriteLine("2.Remove Toys");
                           
                            string toys = Console.ReadLine();
                                switch(toys)
                            {
                                case "1":
                                    addToy();
                                    break;
                                case "2":
                                    removeToy();
                                    break;
                                default:
                                    Console.WriteLine("Value didn’t match earlier.");
                                    break;

                            }
                            break;
                        case "3":
                            Console.WriteLine("1.Add Plants");
                            Console.WriteLine("2.Remove Plants");
                            Console.WriteLine("3.Get Plants");
                            string plants = Console.ReadLine();
                            switch (plants)
                            {
                                case "1":
                                    addPlants();
                                    break;
                                case "2":
                                    removeToy();
                                    break;
                                case "3":
                                    getPlants();
                                    break;
                                default:
                                    Console.WriteLine("Value didn’t match earlier.");
                                    break;

                            }
                            break;
                        case "4":
                            Console.WriteLine("1.Add Promocodes");
                            Console.WriteLine("2.Remove Promocodes");

                            string promo = Console.ReadLine();
                            switch (promo)
                            {
                                case "1":
                                    addPromocode();
                                    break;
                                case "2":
                                    removedPromocode();
                                    break;
                                default:
                                    Console.WriteLine("Value didn’t match earlier.");
                                    break;

                            }
                            break;
                        default:
                            Console.WriteLine("Value didn’t match earlier.");
                            break;
                    }
                    break;
                case "4":

                    Console.WriteLine("Promocodes");
                    getPromocodes();
                   
                    break;
                case "5":
                    Console.WriteLine("Orders");
                    Console.WriteLine("1.Add Orders");
                    Console.WriteLine("2.Remove Ordeers");
                    Console.WriteLine("3.Get Orders");
                    string caseString6 = Console.ReadLine();
                    switch (caseString6)
                    {
                        case "1":
                            addOrders();
                            break;
                        case "2":
                            removeOrders();
                            break;
                        case "3":
                            getOrders();
                            break;
                        default:
                            Console.WriteLine("Value didn’t match earlier.");
                            break;
                    }
                    break;
                
                default:
                    Console.WriteLine("Value didn’t match earlier.");
                    break;
            }
            Console.ReadLine();
        }
        static void addCustomer()
        {
            using (var context = new Context())
            {
                Customers hp = new Customers();
                Console.WriteLine("Enter Customer Name");
                hp.Name = Console.ReadLine();
                Console.WriteLine("Enter PhoneNumber");
                hp.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Enter Email:");
                hp.Email = Console.ReadLine();
                
                context.Customers.Add(hp);
                context.SaveChanges();
            }
        }
        static void removeCustomer()
        {
            using (var context = new Context())
            {
                Customers hp = new Customers();
                Console.WriteLine("Enter Hospital Id");
                hp.CustomerId = Convert.ToInt32(Console.ReadLine());

                context.Customers.Remove(hp);
                context.SaveChanges();
            }

        }
        static void getCustomers()
        {

            using (var context = new Context())
            {
                Customers hp = new Customers();
                //Console.WriteLine("Enter Hospital Id");
                foreach (var item in context.Customers.ToList())
                {
                    Console.WriteLine($"ID {item.CustomerId} and Name {item.Name}-Email{item.Email}-PhonNumber{item.PhoneNumber}");
                }
            }
        }
        static void addAddress()
        {
            using (var context = new Context())
            {
                Addresses dp = new Addresses();
                Console.WriteLine("Enter Addresse Name");
                dp.AddressName = Console.ReadLine();
                Console.WriteLine("Enter Full Address");
                dp.AddressDetail = Console.ReadLine();
                Console.WriteLine("Enter Customer Id");
                dp.CustomerId = Convert.ToInt32(Console.ReadLine());
                context.Addresses.Add(dp);
                context.SaveChanges();
            }
        }
        static void removeAddress()
        {
            using (var context = new Context())
            {
                Addresses hp = new Addresses();
                Console.WriteLine("Enter Address Id");
                hp.AddressId = Convert.ToInt32(Console.ReadLine());

                context.Addresses.Remove(hp);
                context.SaveChanges();
            }

        }
        static void getAddress()
        {

            using (var context = new Context())
            {
                Addresses hp = new Addresses();
               
                foreach (var item in context.Addresses.ToList())
                {
                    Console.WriteLine($"ID {item.AddressId}  Name {item.AddressName} Detail{item.AddressDetail}-CustomerId{item.CustomerId} ");
                }
            }
        }
        static void addOrders()
        {
            using (var context = new Context())
            {
                Orders dp = new Orders();
                Console.WriteLine("Enter CustomerId ");
                dp.CustomerId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Toy Id ");
                dp.ToyId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Number Of Quantity  ");
                dp.NumberOfItem = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Price ");
                dp.Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Total Price is ");
                dp.TotalPrice= dp.Price * dp.NumberOfItem;
                if (dp.TotalPrice == 200)
                    dp.PromocodeId = 1;
                else if (dp.TotalPrice == 500)
                    dp.PromocodeId = 2;
                else if (dp.TotalPrice == 1000)
                    dp.PromocodeId = 3;
                else if (dp.TotalPrice == 2000)
                    dp.PromocodeId = 4;
                else
                    Console.WriteLine("No Promocode Applied");
              
                context.Orders.Add(dp);
                context.SaveChanges();
            }
        }
        static void removeOrders()
        {
            using (var context = new Context())
            {
                Orders hp = new Orders();
                Console.WriteLine("Enter Customer Id");
                hp.CustomerId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Order Id");
                hp.OrderId = Convert.ToInt32(Console.ReadLine());
                context.Orders.Remove(hp);
                context.SaveChanges();
            }

        }
        static void getOrders()
        {

            using (var context = new Context())
            {
                Orders hp = new Orders();
                //Console.WriteLine("Enter Hospital Id");
                foreach (var item in context.Orders.ToList())
                {

                    Console.WriteLine($"ID {item.OrderId} - ToyId {item.ToyId}- Price{item.Price} -Items{item.NumberOfItem}- TotalPrice{item.TotalPrice}-CustomerId{item.CustomerId}-PromocodeId{item.PromocodeId}");
                }
            }
        }
        static void addPlants()
        {
            using (var context = new Context())
            {
                Admin ad = new Admin();
                Console.WriteLine("Enter UserName");
                ad.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                ad.Password = Console.ReadLine();
                var check = context.Admins.SingleOrDefault(t => t.UserName == ad.UserName && t.Password == ad.Password );
                if (check != null)
                {
                    try
                    {
                        Plants dp = new Plants();
                        Console.WriteLine("Enter plant Name");
                        dp.PlantName = Console.ReadLine();

                        context.Plants.Add(dp);
                        context.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect UserName or Password");
                }
            }
        }
        static void removePlants()
        {
            using (var context = new Context())
            {
                Admin ad = new Admin();
                Console.WriteLine("Enter UserName");
                ad.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                ad.Password = Console.ReadLine();
                var check = context.Admins.SingleOrDefault(t => t.UserName == ad.UserName && t.Password == ad.Password);
                if (check != null)
                {
                    try
                    {
                        Plants hp = new Plants();
                        Console.WriteLine("Enter Plant Id");
                        hp.PlantId = Convert.ToInt32(Console.ReadLine());

                        context.Plants.Remove(hp);
                        context.SaveChanges();

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect UserName or Password");
                }
            }

        }
        static void getPlants()
        {
            using (var context = new Context())
            {
                Admin ad = new Admin();
                Console.WriteLine("Enter UserName");
                ad.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                ad.Password = Console.ReadLine();
                var check = context.Admins.SingleOrDefault(t => t.UserName == ad.UserName && t.Password == ad.Password);
                if (check != null)
                {
                    try
                    {
                        Plants hp = new Plants();

                        foreach (var item in context.Plants.ToList())
                        {
                            Console.WriteLine($"ID {item.PlantId} - Name {item.PlantName}");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect UserName or Password");
                }
            }
        }
        
        static void addToy()
        {
            using (var context = new Context())
            {
                Admin ad = new Admin();
                Console.WriteLine("Enter UserName");
                ad.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                ad.Password = Console.ReadLine();
                var check = context.Admins.SingleOrDefault(t => t.UserName == ad.UserName && t.Password == ad.Password);
                if (check != null)
                {
                    try
                    {
                        Toys dp = new Toys();
                        Console.WriteLine("Enter Toy Name");
                        dp.ToyName = Console.ReadLine();
                        Console.WriteLine("Enter Toy Price");
                        dp.ToyPrice = Console.ReadLine();

                        context.Toys.Add(dp);
                        context.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect UserName or Password");
                }
            }
        }
        static void removeToy()
        {
            using (var context = new Context())
            {
                Admin ad = new Admin();
                Console.WriteLine("Enter UserName");
                ad.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                ad.Password = Console.ReadLine();
                var check = context.Admins.SingleOrDefault(t => t.UserName == ad.UserName && t.Password == ad.Password);
                if (check != null)
                {
                    try
                    {
                        Toys hp = new Toys();
                        Console.WriteLine("Enter Toys Id");
                        hp.ToyId = Convert.ToInt32(Console.ReadLine());

                        context.Toys.Remove(hp);
                        context.SaveChanges();

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect UserName or Password");
                }
            }

        }
        static void getToy()
        {
            using (var context = new Context())
            {
                Toys hp = new Toys();

                foreach (var item in context.Toys.ToList())
                {
                    Console.WriteLine($"ID {item.ToyId} - Name {item.ToyName}- ToyPrice{item.ToyPrice}");
                }
            }


        }
        static void addAdmin()
        {
            using (var context = new Context())
            {
                Admin dp = new Admin();
                Console.WriteLine("Enter Admin Name");
                dp.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                dp.Password = Console.ReadLine();

                context.Admins.Add(dp);
                context.SaveChanges();
            }
        }
        static void removedeAdmin()
        {
            using (var context = new Context())
            {
                Admin hp = new Admin();
                Console.WriteLine("Enter Admin Id");
                hp.Id = Convert.ToInt32(Console.ReadLine());

                context.Admins.Remove(hp);
                context.SaveChanges();
            }

        }
        static void getAdmin()
        {

            using (var context = new Context())
            {
                Admin hp = new Admin();
              
                foreach (var item in context.Admins.ToList())
                {
                    Console.WriteLine($"ID {item.Id} - Name {item.UserName}-Password{item.Password} ");
                }
            }
        }
        static void addPromocode()
        {
            using (var context = new Context())
            {
                Admin ad = new Admin();
                Console.WriteLine("Enter UserName");
                ad.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                ad.Password = Console.ReadLine();
                var check = context.Admins.SingleOrDefault(t => t.UserName == ad.UserName && t.Password == ad.Password);
                if (check != null)
                {
                    try
                    {
                        Promocodes dp = new Promocodes();
                        Console.WriteLine("Enter Promocode Name");
                        dp.PromocodeName = Console.ReadLine();
                        Console.WriteLine("Enter Promo Details");
                        dp.Detail = Console.ReadLine();

                        context.Promocodes.Add(dp);
                        context.SaveChanges();


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect UserName or Password");
                }

            }
        }
        static void removedPromocode()
        {
            using (var context = new Context())
            {
                Admin ad = new Admin();
                Console.WriteLine("Enter UserName");
                ad.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                ad.Password = Console.ReadLine();
                var check = context.Admins.SingleOrDefault(t => t.UserName == ad.UserName && t.Password == ad.Password);
                if (check != null)
                {
                    try
                    {
                        Promocodes hp = new Promocodes();
                        Console.WriteLine("Enter Promocode Id");
                        hp.PromocodeId = Convert.ToInt32(Console.ReadLine());

                        context.Promocodes.Remove(hp);
                        context.SaveChanges();

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect UserName or Password");
                }
            }

        }
        static void getPromocodes()
        {

            using (var context = new Context())
            {
                Promocodes hp = new Promocodes();
               
                foreach (var item in context.Promocodes.ToList())
                {
                    Console.WriteLine($"ID {item.PromocodeId} - Name {item.PromocodeName}-Detail{item.Detail} ");
                }
            }
        }
        


    }
}