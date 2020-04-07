using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class AddExpenseDto
    {
        public Guid UserId { get; set; }
        public int Amount { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Name{ get; set; }

        public List<StoreCategoryDto> Categories { get; set; }

    }
}
