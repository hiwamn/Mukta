using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Dto
{
    public class RegisterUserDto
    {
        public string Password { get; set; }
        public string PushId { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public int CityId { get; set; }
        public long Birthday { get; set; }
        public int Gender { get; set; }
        public string ReferenceMobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
    }
}
