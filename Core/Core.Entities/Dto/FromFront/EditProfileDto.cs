using System;

namespace Core.Entities.Dto
{
    public class EditProfileDto
    {
        public Guid UserId { get; set; }
        public Guid ImageId { get; set; }
        public string Name{ get; set; }
        public string FamilyName{ get; set; }
        public int? CityId{ get; set; }
    }
}
