#nullable disable
using DemoApartment.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApartment.DBOperations
{
    public class DataGenerator
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ManagementDbContext>();
                
                context.Database.Migrate();                     // mig varsa veritabanını oluşturur

                // ***** Renters ***** //
                if (!context.Renters.Any())
                {
                    context.Renters.AddRange(new List<Renter>()
                    {
                        new Renter {FullName = "İhsan Yenilmez", IdentityNumber = "10110110120", EMail = "ihsan@seeddata.com", PhoneNumber = "505 555 1111", IsHomeOwner = false, CarPlate = "-", IsDeleted = false },
                        new Renter {FullName = "Selim Karaca", IdentityNumber = "20110110120", EMail = "selim@seeddata.com", PhoneNumber = "505 555 2222", IsHomeOwner = false, CarPlate = "-", IsDeleted = false, },
                        new Renter {FullName = "Süleyman Demir", IdentityNumber = "30110110120", EMail = "suleyman@seeddata.com", PhoneNumber = "505 555 3333", IsHomeOwner = false, CarPlate = "-", IsDeleted = false, },
                        new Renter {FullName = "Emine Yıldırım", IdentityNumber = "40110110120", EMail = "emine@seeddata.com", PhoneNumber = "505 555 4444", IsHomeOwner = false, CarPlate = "-", IsDeleted = false, },
                        new Renter {FullName = "Salih Yurdakul", IdentityNumber = "50110110120", EMail = "salih@seeddata.com", PhoneNumber = "505 555 5555", IsHomeOwner = false, CarPlate = "-", IsDeleted = false, },
                        new Renter {FullName = "Zafer Çağlayan", IdentityNumber = "60110110120", EMail = "zafer@seeddata.com", PhoneNumber = "505 555 6666", IsHomeOwner = false, CarPlate = "-", IsDeleted = false, },
                        new Renter {FullName = "Hakan Filiz", IdentityNumber = "70110110120", EMail = "hakan@seeddata.com", PhoneNumber = "505 555 7777", IsHomeOwner = false, CarPlate = "-", IsDeleted = false, },
                        new Renter {FullName = "Berrin Miral", IdentityNumber = "80110110120", EMail = "berrin@seeddata.com", PhoneNumber = "505 555 8888", IsHomeOwner = false, CarPlate = "-", IsDeleted = false, },
                        new Renter {FullName = "Umay Zengin", IdentityNumber = "90110110120", EMail = "umay@seeddata.com", PhoneNumber = "505 555 9999", IsHomeOwner = false, CarPlate = "-", IsDeleted = false, }
                    });
                    context.SaveChanges();
                }
                // ***** Apartments ***** //
                if (!context.Apartments.Any())
                {
                    context.Apartments.AddRange(new List<Apartment>()
                    {
                        new Apartment { Block = "A Blok", Floor = 1, DoorNumber = 1, IsAvailable = false, Type = "4+1", IsOwner = false, IsDeleted = false, RenterId = 1 },
                        new Apartment { Block = "A Blok", Floor = 1, DoorNumber = 2, IsAvailable = false, Type = "4+1", IsOwner = false, IsDeleted = false, RenterId = 2 },
                        new Apartment { Block = "A Blok", Floor = 1, DoorNumber = 3, IsAvailable = false, Type = "4+1", IsOwner = false, IsDeleted = false, RenterId = 3 },
                        new Apartment { Block = "A Blok", Floor = 1, DoorNumber = 4, IsAvailable = false, Type = "4+1", IsOwner = false, IsDeleted = false, RenterId = 4 },
                        new Apartment { Block = "A Blok", Floor = 2, DoorNumber = 5, IsAvailable = false, Type = "4+1", IsOwner = false, IsDeleted = false, RenterId = 5 },
                        new Apartment { Block = "A Blok", Floor = 2, DoorNumber = 6, IsAvailable = false, Type = "4+1", IsOwner = false, IsDeleted = false, RenterId = 6 },
                        new Apartment { Block = "A Blok", Floor = 2, DoorNumber = 7, IsAvailable = false, Type = "4+1", IsOwner = false, IsDeleted = false, RenterId = 7 },
                        new Apartment { Block = "A Blok", Floor = 2, DoorNumber = 8, IsAvailable = false, Type = "4+1", IsOwner = false, IsDeleted = false, RenterId = 7 },
                        new Apartment { Block = "A Blok", Floor = 3, DoorNumber = 9, IsAvailable = false, Type = "4+1", IsOwner = false, IsDeleted = false, RenterId = 7 },
                        new Apartment { Block = "A Blok", Floor = 3, DoorNumber = 10, IsAvailable = false, Type = "4+1", IsOwner = false, IsDeleted = false, RenterId = 8 },
                        new Apartment { Block = "A Blok", Floor = 3, DoorNumber = 11, IsAvailable = false, Type = "4+1", IsOwner = false, IsDeleted = false, RenterId = 8 },
                        new Apartment { Block = "A Blok", Floor = 3, DoorNumber = 12, IsAvailable = false, Type = "4+1", IsOwner = false, IsDeleted = false, RenterId = 9 }
                    });
                    context.SaveChanges();
                }

                // ***** Bills ***** //
                if (!context.Bills.Any())
                {
                    context.Bills.AddRange(new List<Bill>()
                    {
                        new Bill {BillType = BillType.Aidat, DueDate = DateTime.Now, AmountPayable = 150, IsPaid = false },
                        new Bill {BillType = BillType.Aidat, DueDate = DateTime.Now, AmountPayable = 175, IsPaid = false },
                        new Bill {BillType = BillType.Aidat, DueDate = DateTime.Now, AmountPayable = 200, IsPaid = false },
                        new Bill {BillType = BillType.Su, DueDate = DateTime.Now, AmountPayable = 130, IsPaid = false },
                        new Bill {BillType = BillType.Doğalgaz, DueDate = DateTime.Now, AmountPayable = 270, IsPaid = false },
                        new Bill {BillType = BillType.Elektrik, DueDate = DateTime.Now, AmountPayable = 350, IsPaid = false },
                        new Bill {BillType = BillType.İnternet, DueDate = DateTime.Now, AmountPayable = 490, IsPaid = false }
                    });
                    context.SaveChanges();
                }

                // ***** Apartments_Bills ***** //
                if (!context.Apartments_Bills.Any())
                {
                    context.Apartments_Bills.AddRange(new List<Apartment_Bill>()
                    {
                        new Apartment_Bill { ApartmentId = 1, BillId = 1 },
                        new Apartment_Bill { ApartmentId = 1, BillId = 2 },
                        new Apartment_Bill { ApartmentId = 1, BillId = 3 },
                        new Apartment_Bill { ApartmentId = 1, BillId = 4 },
                        new Apartment_Bill { ApartmentId = 1, BillId = 5 },
                        new Apartment_Bill { ApartmentId = 2, BillId = 1 }
                    });
                    context.SaveChanges();
                }

                // ***** Managers ***** //
                if (!context.Managers.Any())
                {
                    context.Managers.AddRange(new List<Manager>()
                    {

                    });
                    context.SaveChanges();
                }

                // ***** Messages ***** //
                if (!context.Messages.Any())
                {
                    context.Messages.AddRange(new List<Message>()
                    {

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}