using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VillainActivityMonitor.API.Models
{
    public class Villain
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Alias { get; set; } = string.Empty;
    }
}