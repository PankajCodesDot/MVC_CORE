using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CORE.Models
{
    public class TableCollection:tblemployee
    {
        public List<tblgender> tblgenders { get; set; }
        public List<tblcountry> tblcountries { get; set; }
     
    }
}
