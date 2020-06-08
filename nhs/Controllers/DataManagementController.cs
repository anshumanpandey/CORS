using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHS.Common;
using NHS.Data;
using System.Configuration;

namespace NHS.Controllers
{
    public class DataManagementController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DataManagementDetails(clsDataManagement clsPatientDetails)
        {
            bool isUser = GetUserDetailsFromAD();
            List<clsDataManagement> datamanagement = new List<clsDataManagement>();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            datamanagement = dBEngine.GetDataSets(Convert.ToInt32(Session["LoginUserID"]));
            return View(datamanagement);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool GetUserDetailsFromAD()
        {
            bool isValid = false;
            string FullName = string.Empty;
            DBEngine dBEngine = new DBEngine(ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString);

            try
            {
                //string LDAPUrl = ConfigurationManager.AppSettings["LDAPURL"].ToString();
                string userName = Environment.GetEnvironmentVariable("USERNAME");
                //if (string.IsNullOrWhiteSpace(LDAPUrl))
                //{
                //    if (string.IsNullOrWhiteSpace(UserName))
                //    {
                //        dBEngine.WriteLog("LDAPUrl is blank or not provided & UserName could not be retieved from environment");
                //        TempData["FullName"] = "";
                //    }
                //    else
                //    {
                //        dBEngine.WriteLog($"LDAPUrl is blank or not provided but UserName {UserName} was retieved from environment");
                //        TempData["FullName"] = UserName;
                //    }
                //}
                //else
                //{
                if (string.IsNullOrWhiteSpace(userName))
                {
                    Session["FullName"] = "";
                    //dBEngine.WriteLog($"UserName could not be retieved from environment");
                }
                //else
                //{
                //    DirectoryEntry rootEntry = new DirectoryEntry(LDAPUrl);
                //    rootEntry.AuthenticationType = AuthenticationTypes.None;
                //    DirectorySearcher searcher = new DirectorySearcher(rootEntry);
                //    var queryFormat = "(&(objectClass=user)(objectCategory=person)(|(SAMAccountName=*{0}*)(cn=*{0}*)(gn=*{0}*)(sn=*{0}*)(email=*{0}*)))";
                //    searcher.Filter = string.Format(queryFormat, UserName);
                //    foreach (SearchResult result in searcher.FindAll())
                //    {
                //        FullName = result.Properties["cn"].Count > 0 ? result.Properties["cn"][0].ToString() : string.Empty;
                //    }
                //    if (string.IsNullOrWhiteSpace(FullName))
                //    {
                //        dBEngine.WriteLog($"LDAP URL was provided {LDAPUrl} BUT User - {UserName} not found in AD");
                //        FullName = UserName;
                //        isValid = false;
                //    }
                //else
                //{
                //AppUsers user = dBEngine.ValidateUser(userName);
                //if (user.IsFound == true)
                //    isValid = true;
                //else
                //    isValid = false;
                //Session["FullName"] = user.FirstName + " " + user.LastName;
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
            }
            return isValid;
        }
    }
}