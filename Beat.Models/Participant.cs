using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beat.Models.Enums;

namespace Beat.Models
{
    public class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }
        
        public List<Event> Events { get; set; }

    }
}
