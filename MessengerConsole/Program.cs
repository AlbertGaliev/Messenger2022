using MessengerData.EF;
using MessengerData.Entities;
using MessengerData.Entities.Enums;
using MessengerData.Repositories;
using System;

namespace MessengerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MessengerDbContext())
            {
                var repos = new UserRepository(db);
                var repos1 = new UserStatusRepository(db);
                var user = new User()
                {
                    FirstName = "Albert",
                    LastName = "Galerv",
                    MiddleName = "Ildarovich",
                    Email = "qwerty@mail.ru",
                    CreationTime = DateTime.Now,
                    Login = "albert666",
                    Password = "123",
                    Phone = "88005553535"
                };

                var user2 = new User()
                {
                    FirstName = "Albert",
                    LastName = "Galerv",
                    MiddleName = "Ildarovich",
                    Email = "qwerty@mail.ru",
                    CreationTime = DateTime.Now,
                    Login = "albert666",
                    Password = "123",
                    Phone = "88005553535"
                };

                repos.Create(user2);
                var userStatus = new UserStatus()
                {
                    User = user,
                    Status = UserOnlineStatus.IsOffline,
                    CreationTime = DateTime.Now
                };



            }
        }
    }
}
