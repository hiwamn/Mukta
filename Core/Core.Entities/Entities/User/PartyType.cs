using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class PartyType 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Party> Parties { get; set; }
    }
}
