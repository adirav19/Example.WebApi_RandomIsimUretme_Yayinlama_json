using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.API.Models;

namespace UserManagement.API.Fake
{
    public class FakeData
    {
        private static List<User> users;
        public static List<User> GetUsers(int number)
        {
            if (users == null)
            {
                users = new Faker<User>()
                    .RuleFor(u => u.Id, f => f.IndexFaker + 1)
                    .RuleFor(u => u.Name, f => f.Name.FirstName())
                    .RuleFor(u => u.Address, f => f.Address.FullAddress())
                    .Generate(number);
            }
            return users;
        }
        
        
    }
}
