using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beat.Models.Enums;

namespace Beat.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public List<Member> TrackMembers { get; set; }
    }
}
