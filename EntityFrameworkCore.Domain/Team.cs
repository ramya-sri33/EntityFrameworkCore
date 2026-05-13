using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCore.Domain
{
    public class Team:BaseClass
    {

        public int TeamId { get; set; }
        public string? Name { get; set; }
        
    }
}
