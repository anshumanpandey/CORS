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
using System.Net.Mail;

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

        public ActionResult Register()
        {
            AppUsers usermodel = new AppUsers();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            ViewBag.RoleDDM = dBEngine.GetRoles(0);
            ViewBag.SpecialityDDM = dBEngine.GetSpecialitiesForDropDown(0);
            return View(usermodel);
        }

        public static void SendEmail(string ReceiverEmailID, string EmailSubject, string MessageBody, string application = "")
        {
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);

            WebsiteSetting setting = dBEngine.GetWebsiteSettings(0);

            #region Email
            string SMTPCLIENT = setting.SMTPServer;
            string EMAILID = setting.EmailID;
            string PASSWORD = setting.Password;
            int PORT = setting.Port;
            bool ENABLESSL = false;
            string EMAIL_DISPLAYNAME = "CORS";
            #endregion


            try
            {

                MailMessage mail = new MailMessage();
                string smtp = SMTPCLIENT; //ServerSettings.SMTPCLIENT;

                SmtpClient SmtpServer = new SmtpClient(SMTPCLIENT);//new SmtpClient(ServerSettings.SMTPCLIENT);

                //mail.From = new MailAddress(ServerSettings.EMAILID, ServerSettings.EMAIL_DISPLAYNAME);
                mail.From = new MailAddress(EMAILID, EMAIL_DISPLAYNAME);
                mail.To.Add(ReceiverEmailID);

                mail.Subject = HttpUtility.HtmlDecode(EmailSubject);
                String emailBody = MessageBody;
                mail.Body = HttpUtility.HtmlDecode(emailBody);


                mail.IsBodyHtml = true;
                //SmtpServer.Port = ServerSettings.PORT;
                SmtpServer.Port = PORT;
                //SmtpServer.Credentials = new System.Net.NetworkCredential(ServerSettings.EMAILID, ServerSettings.PASSWORD);
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(EMAILID, PASSWORD);
                //SmtpServer.EnableSsl = ServerSettings.ENABLESSL;
                SmtpServer.EnableSsl = ENABLESSL;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                dBEngine.LogException(ex.Message, "HomeController", "SendEmail", System.DateTime.Now, 0);
            }
        }

        [HttpPost]
        public ActionResult CreateUser()
        {
            string controllername = "";
            string actionname = ""; ;
            AppUsers usermodel = new AppUsers();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            int dbReturn = dBEngine.CreateUser(Request.Form["EmailID"], Request.Form["FirstName"], Request.Form["LastName"], Request.Form["UserName"], Request.Form["ddlSpeciality"], Convert.ToInt32(Request.Form["DischargeRole"]), Request.Form["Code"], 0);
            if(dbReturn == 0)
            {
                Alert alertMessage = new Alert();
                alertMessage.AlertType = ALERTTYPE.Error;
                alertMessage.MessageType = ALERTMESSAGETYPE.TextWithClose;
                alertMessage.Message = "We have taken your request for registering to the CORS platform. You would get a confirmation email once your registration is approved.";
                TempData["AlertMessage"] = alertMessage.Message;
                List<NotificationSettings> settings = dBEngine.GetNotificationSettingsByTrigger("Create User", 0);
                if (settings.Count > 0)
                {
                    for (int counter = 0; counter < settings.Count; counter++)
                    {
                        List<AppUsers> users = dBEngine.GetUsersByRoleID(settings[counter].RoleID, 0);
                        for (int count = 0; count < users.Count; count++)
                        {
                            SendEmail(users[count].EmailID, "CORS - New User for Approval", settings[counter].EmailTemplate.Replace("##FullName##", Request.Form["FirstName"] + " " + Request.Form["LastName"]));
                        }
                    }
                }
                controllername = "Account";
                actionname = "Index";
            }
            else if(dbReturn == -1)
            {
                Alert alertMessage = new Alert();
                alertMessage.AlertType = ALERTTYPE.Error;
                alertMessage.MessageType = ALERTMESSAGETYPE.TextWithClose;
                alertMessage.Message = "User already exists, please proceed to login or contact administrator.";
                TempData["AlertMessage"] = alertMessage.Message;
                controllername = "Account";
                actionname = "Index";
            }
            else
            {
                usermodel = dBEngine.ValidateUser(Request.Form["UserName"], "");
                Session["LoginUserID"] = usermodel.ID;
                Session["UserName"] = Request.Form["UserName"];
                Session["FirstName"] = usermodel.FirstName;
                Session["LastName"] = usermodel.LastName;
                Session["StartDate"] = "";
                Session["EndDate"] = "";
                Session["WardDeath"] = "";
                Session["PatientType"] = "";
                Session["DischargeConsultant"] = "";
                Session["Speciality"] = "";
                Session["TotalDeaths"] = 0;
                Session["QAPCount"] = 0;
                Session["MedCount"] = 0;
                Session["Role"] = usermodel.Role;
                controllername = "Home";
                actionname = "Index";
            }
            return RedirectToAction(actionname, controllername);
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
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            bool isValidFromAD = false;

            if (username.IndexOf("\\") > 0)
            {
                username = username.Split("\\".ToCharArray())[1];
               // domain = username.Split("\\".ToCharArray())[0];
            }
            domain = dBEngine.GetDomainName(0) ;
            
            AppUsers usermodel = new AppUsers();
            
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
                        Session.Timeout = 1440;
                        Session["LoginUserID"] = usermodel.ID;
                        Session["UserName"] = username;
                        Session["FirstName"] = usermodel.FirstName;
                        Session["LastName"] = usermodel.LastName;
                        Session["StartDate"] = "";
                        Session["EndDate"] = "";
                        Session["WardDeath"] = "";
                        Session["PatientType"] = "";
                        Session["DischargeConsultant"] = "";
                        Session["Speciality"] = "";
                        Session["TotalDeaths"] = 0;
                        Session["QAPCount"] = 0;
                        Session["MedCount"] = 0;
                        Session["Role"] = usermodel.Role;
                        int dbReturn = dBEngine.UpdateLoginDateTime(usermodel.ID);
                        controllername = "Home";
                    }
                    else
                    {
                        Alert alertMessage = new Alert();
                        alertMessage.AlertType = ALERTTYPE.Error;
                        alertMessage.MessageType = ALERTMESSAGETYPE.TextWithClose;
                        alertMessage.Message = "You are not authorised to access this app. Please call 8066/6761/5252/8335.";
                        TempData["AlertMessage"] = alertMessage.Message;
                        controllername = "Account";
                    }
                }
                else
                {
                    Alert alertMessage = new Alert();
                    alertMessage.AlertType = ALERTTYPE.Error;
                    alertMessage.MessageType = ALERTMESSAGETYPE.TextWithClose;
                    alertMessage.Message = "Credentials provided do not match with AD.";
                    TempData["AlertMessage"] = alertMessage.Message;
                    controllername = "Account";
                }
            }
            catch (Exception ex)
            {
                Alert alertMessage = new Alert();
                alertMessage.AlertType = ALERTTYPE.Error;
                alertMessage.MessageType = ALERTMESSAGETYPE.TextWithClose;
                alertMessage.Message = "SQL/AD Connection Error. Error Details - " + ex.Message;
                TempData["AlertMessage"] = alertMessage.Message;
                controllername = "Account";
            }
            return RedirectToAction(actionname, controllername);// RedirectToAction("Index");
        }

        public ActionResult Logout()
        {
            //ApplicationSession.LoginUserID = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            int dbReturn = dBEngine.UpdateLogoutDateTime(Convert.ToInt32(Session["LoginUserID"]));
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