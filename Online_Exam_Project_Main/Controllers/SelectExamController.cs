using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_Exam_Project_Main.Models;

namespace Online_Exam_Project_Main.Controllers
{
    public class SelectExamController : Controller
    {
        private MyDbContext db = new MyDbContext();
        //
        // GET: /SelectExam/
        public ActionResult Index()
        {
            if (ModelState.IsValid)
            {
                int count = 0;
                var name = db.Exam_tbl.ToList();
                SelectList list = new SelectList(name, "exam_id", "exam_title");
                DrpList drp = new DrpList();
                drp.Examlist = name;
                drp.QuestionNo = 1;
                ViewBag.name = list;
                Session["name"] = ViewBag.name;
                string message = TempData["Message"] as string;
                drp.msg= message;
                return View(drp);
            }
            return null;
        }
        [HttpPost]
        public void SetFromDrp(int val)
        {
            ViewBag.drpVal = val;
        }
	}
}