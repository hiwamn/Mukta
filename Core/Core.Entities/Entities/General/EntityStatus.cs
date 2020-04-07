using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class EntityStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Lead> Lead { get; set; }
        public List<Order> Order{ get; set; }
        public List<Expense> Expense{ get; set; }
        public List<Feedback> Feedback{ get; set; }
    }
}


