
using System;
using System.Collections.Generic;
using Utility.Tools.Auth;

namespace Core.Entities.Dto
{
    public class UserLoginDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string Mobile { get; set; }
        public long RegisterDate { get; set; }
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public int? CityId { get; set; }
        public string CityName { get; set; }
        public bool Active { get; set; }
        public JsonWebToken Token { get; set; }
        public string ProfileImage { get; internal set; }
        public long Birthday { get; internal set; }
        public string City { get; internal set; }
        public string Country { get; internal set; }
        public long CreatedAt { get; internal set; }
        public string Email { get; internal set; }
        public int Gender { get; internal set; }
        public string Image { get; internal set; }
        public string Provience { get; internal set; }
        public int Status { get; internal set; }
    }
}
