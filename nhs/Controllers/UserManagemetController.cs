using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHS.Common;
using NHS.Data;

namespace NHS.Controllers
{
    public class UserManagemetController : Controller
    {
        //NHSEntities ent = new NHSEntities();
        // GET: UserManagemet
        public ActionResult Index()
        {
            //string ConStr = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            //DBEngine dBEngine = new DBEngine(ConStr);
            //int x = dBEngine.GetScalar<int>("select patientid from patientdetails where patientname='John'");
            //List<clsPatientDetails> patientList=  dBEngine.GetList<clsPatientDetails>("select * from patientdetails");

            //clsPatientDetails p = new clsPatientDetails();
            //p.Comments = "fff";

            //int ReturnValue = dBEngine.AddComments(p);
            return View();
        }
        public ActionResult UserDetails()
        {
            //ViewBag.Drodown = (from x in ent.Roles select x).ToList();
            return View();
        }
    }
}