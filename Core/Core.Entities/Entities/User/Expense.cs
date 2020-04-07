using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Expense : UserBaseEntity
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }


        public int StatusId { get; set; }
        public EntityStatus Status { get; set; }

        public List<ExpenseCategory> Categories { get; set; }
    }
}
