using System;
using System.Collections.Generic;
using System.Text;
using Utility.Tools.Auth;

namespace Core.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string Email{ get; set; }
        public long?  Birthday{ get; set; }
        public int?  Gender{ get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public int Status{ get; set; }

        public Guid? ReferenceId { get; set; }
        public User Reference { get; set; }

        public int? CityId { get; set; }
        public City City { get; set; }
        
        
        
        public string Salt { get; set; }

        public Guid? ProfileImageId { get; set; }
        public Document ProfileImage { get; set; }

        public List<Device> Device{ get; set; }
        public List<Notification> Notification { get; set; }
        public List<UserRole> UserRole { get; set; }
        public List<WorkTime> WorkTime { get; set; }
        public List<Lead> Lead { get; set; }
        public List<Expense> Expense { get; set; }
        public List<UserImage> UserImages { get; set; }

        public void SetPassword(string password, IEncrypter encrypter)
        {
            Salt = encrypter.GetSalt();
            Password = encrypter.GetHash(password, Salt);
        }

        public bool ValidatePassword(string password, IEncrypter encrypter) =>
            Password.Equals(encrypter.GetHash(password, Salt));
    }
}
