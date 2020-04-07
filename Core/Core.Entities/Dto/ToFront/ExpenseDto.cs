
using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class ExpenseDto
    {
        public int Amount { get; internal set; }
        public List<StoreCategoryDto> Categories { get; internal set; }
        public long CreatedAt { get; internal set; }
        public Guid Id { get; internal set; }
        public double Lat { get; internal set; }
        public double Lon { get; internal set; }
        public int StatusId { get; internal set; }
        public object Name { get; internal set; }
    }


}
