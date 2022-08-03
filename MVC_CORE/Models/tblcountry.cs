using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CORE.Models
{
    public class tblcountry
    {
        [Key]
        public int cid { get; set; }
        public string cname { get; set; }
    }
}
