using Microsoft.AspNetCore.Mvc;
using MVC_CORE.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVC_CORE.Controllers
{
    public class EmpController : Controller
    {
        private readonly DatabaseContext db;
        public EmpController(DatabaseContext context)
        {
            db = context;
        }
        public IActionResult Add(int id)
        {
            TableCollection obj = new TableCollection();
            obj.tblgenders = db.tblgenders.ToList();
            obj.tblcountries = db.tblcountries.ToList();
            
            ViewBag.BT = "Save";
            if(id>0)
            {
                var data = db.tblemployees.Where(x => x.id == id).ToList();
                obj.id = data[0].id;
                obj.name = data[0].name;
                obj.address = data[0].address;
                obj.gender = data[0].gender;
                obj.country = data[0].country;
                obj.state = data[0].state;
              
                ViewBag.BT = "Update";
            }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Add(tblemployee emp)
        {
           if(emp.id>0)
            {
                db.Entry(emp).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
           else
            {
                db.tblemployees.Add(emp);
            }
            db.SaveChanges();
            return RedirectToAction("Show");
        }
        public IActionResult Show()
        { 
            var data = (from a in db.tblemployees
                        join b in db.tblgenders on a.gender equals b.gid
                        join c in db.tblcountries on a.country equals c.cid
                        join d in db.tblstates on a.state equals d.sid
                        select new tblemployees1 {
                            id = a.id,
                            name = a.name,
                            address = a.address,
                            gname = b.gname,
                            cname = c.cname,
                            sname = d.sname
                        }).ToList();
            return View(data);
        }
        public IActionResult Delete(int id=0)
        {
            var data = db.tblemployees.Find(id);
            db.tblemployees.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Show");
        }
        public JsonResult GetState(int A)
        {
           // var data = (from a in db.tblstates where a.cid == A select a).ToList();
            var data = db.tblstates.Where(a => a.cid == A).ToList();
            return Json(data);
        }
    }
}