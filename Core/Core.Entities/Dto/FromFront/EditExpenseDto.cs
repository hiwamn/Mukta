using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class EditExpenseDto
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }

        public List<StoreCategoryDto> Categories { get; set; }

    }
}
