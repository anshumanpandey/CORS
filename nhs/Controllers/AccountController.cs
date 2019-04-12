using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHS.Common.DTO;
using NHS.Data;
using NHS.Common;
using System.Configuration;
using System.Net;
using System.DirectoryServices.Protocols;

namespace NHS.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            AppUsers usermodel = new AppUsers();
            return View(usermodel);
        }

        [HttpPost]
        public ActionResult Login()
        {
            string controllername = "";
            ViewBag.AlertMessage = "";
            string actionname = "";
            string username = Request.Form["Email"];
            string password = Request.Form["Password"];
            string domain = "";
            bool isValidFromAD = false;

            if (username.IndexOf("\\") > 0)
            {
                username = username.Split("\\".ToCharArray())[1];
                domain = username.Split("\\".ToCharArray())[0];
            }
            else
            {
                domain = "RBBH_MSDOMAIN1";
            }
            AppUsers usermodel = new AppUsers();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                isValidFromAD = ValidateCredentials(username, password, domain);
                //isValidFromAD = true;
                if (isValidFromAD)
                {
                    usermodel = dBEngine.ValidateUser(username, password);
                    actionname = "Index";
                    if (usermodel.IsFound)
                    {
                        //Session.Abandon();
                        Session["LoginUserID"] = usermodel.ID;
                        Session["FirstName"] = usermodel.FirstName;
                        Session["LastName"] = usermodel.LastName;

                        //newly added for gettin role to be display in comments section
                        Session["Role"]= usermodel.Role;
                        //newly added
                        Session["StartDate"] = "";
                        Session["EndDate"] = "";
                        Session["WardDeath"] = "";
                        Session["PatientType"] = "";
                        Session["DischargeConsultant"] = "";
                        Session["Speciality"] = "";
                        Session["TotalDeaths"] = 0;
                        Session["QAPCount"] = 0;
                        Session["MedCount"] = 0;

                        controllername = "Home";
                    }
                    else
                    {
                        Alert alertMessage = new Alert();
                        alertMessage.AlertType = ALERTTYPE.Error;
                        alertMessage.MessageType = ALERTMESSAGETYPE.TextWithClose;
                        alertMessage.Message = "Credentials matched with AD but user has not been setup in CORS app.";
                        TempData["AlertMessage"] = alertMessage.Message;
                        controllername = "Account";
                    }
                }
                else
                {
                    Alert alertMessage = new Alert();
                    alertMessage.AlertType = ALERTTYPE.Error;
                    alertMessage.MessageType = ALERTMESSAGETYPE.TextWithClose;
                    //alertMessage.Message = "Credentials provided do not match with AD.";
                    alertMessage.Message = "Require access to CORS? Click here to Contact Us";
                    TempData["AlertMessage"] = alertMessage.Message;
                    controllername = "Account";
                }
            }
            catch (Exception ex)
            {
                Alert alertMessage = new Alert();
                alertMessage.AlertType = ALERTTYPE.Error;
                alertMessage.MessageType = ALERTMESSAGETYPE.TextWithClose;
                alertMessage.Message = "Unable to connect to SQL. Error Details - " + ex.Message;
                TempData["AlertMessage"] = alertMessage.Message;
                controllername = "Account";
            }
            return RedirectToAction(actionname, controllername);// RedirectToAction("Index");
        }

        public ActionResult Logout()
        {
            //ApplicationSession.LoginUserID = 0;
            Session.RemoveAll();
            return RedirectToAction("Index", "Account" );
        }

        private bool ValidateCredentials(string username, string password, string domain)
        {
            NetworkCredential credentials
              = new NetworkCredential(username, password, domain);

            LdapDirectoryIdentifier id = new LdapDirectoryIdentifier(domain);

            using (LdapConnection connection = new LdapConnection(id, credentials, AuthType.Kerberos))
            {
                connection.SessionOptions.Sealing = true;
                connection.SessionOptions.Signing = true;

                try
                {
                    connection.Bind();
                }
                catch (LdapException lEx)
                {
                    if (lEx.ErrorCode == 49)
                    {
                        return false;
                    }
                    throw;
                }
            }
            return true;
        }
    }
}