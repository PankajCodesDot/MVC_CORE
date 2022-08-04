using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CORE.Models
{
    public class tblstate
    {
        [Key]
        public int sid { get; set; }
        public int cid { get; set; }
        public string sname { get;set; }
    }
}
