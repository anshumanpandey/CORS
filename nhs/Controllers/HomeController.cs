﻿using NHS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using NHS.Common;
using NHS.Data;
using System.Web.UI;
using System.Configuration;
using System.Security.Principal;
using System.IO;
using System.DirectoryServices;
using System.Web.SessionState;
using NHS.Common.DTO;


namespace NHS.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class HomeController : Controller
    {
        //NHSEntities ent = new NHSEntities();
        public ActionResult Index()
        {
            Session["FullName"] = "";
            Session["TotalDeaths"] = "";
            if (Convert.ToInt32(Session["LoginUserID"]) > 0)
            {
                bool isuser = GetUserDetailsFromAD();
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Account");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult PositiveFeedback(int? id)
        {
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");
            bool isUser = GetUserDetailsFromAD();
            clsFeedBackModel feedback = new clsFeedBackModel();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                //if (ApplicationSession.LoginUserID > 0)
                //{
                try
                {
                    feedback = dBEngine.GetFeedback(id);
                    if (feedback.Patient_ID == 0 || feedback.Patient_ID == null)
                        feedback.Patient_ID = Convert.ToInt32(id);
                }
                catch (Exception ex)
                {
                    dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
                }
                //}
                //else
                //{
                //    return RedirectToAction("Index", "Account");
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(feedback);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="clsFeedBackModel"></param>
        /// <param name="BtnPrevious"></param>
        /// <param name="BtnFinish"></param>
        /// <param name="BtnNext"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult PositiveFeedback(FormCollection formCollection, string BtnPrevious, string BtnNext, int id)
        {
            string actionName = "";
            bool isFormCompleted = false;
            bool isComplementsFedBack = false;
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);

            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                if (BtnPrevious != null)
                    actionName = "OtherReferrals";
                //if (BtnSave != null)
                //    actionName = "MortalityReview";


                if (BtnNext != null)
                {
                    actionName = "MeDeclaration";
                    if (Convert.ToString(formCollection["FormCompleted"]) == "on") isFormCompleted = true;
                    if (Convert.ToString(formCollection["ComplementsFedBack"]) == "on") isComplementsFedBack = true;
                    int retVal = dBEngine.UpdatePositiveFeedback(isFormCompleted, isComplementsFedBack, formCollection["Comments"], id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction(actionName, new { id = id });
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="clsFeedBackModel"></param>
        ///// <param name="BtnPrevious"></param>
        ///// <param name="BtnFinish"></param>
        ///// <param name="BtnNext"></param>
        ///// <returns></returns>
        //[HttpPost]
        //public ActionResult PositiveFeedback(FormCollection formCollection, string BtnPrevious, string BtnSave, string BtnFinish, string BtnNext, int id)
        //{
        //    string actionName = "";
        //    bool isFormCompleted = false;
        //    bool isComplementsFedBack = false;
        //    string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
        //    DBEngine dBEngine = new DBEngine(connectionString);

        //    try
        //    {
        //        if (id == null || id == 0)
        //        {
        //            if (Session["PatientID"] != null)
        //                id = Convert.ToInt32(Session["PatientID"]);
        //            else
        //                return RedirectToAction("Index", "Account");
        //        }
        //        if (BtnPrevious != null)
        //            actionName = "OtherReferrals";
        //        if (BtnSave != null)
        //            actionName = "MortalityReview";


        //        if (BtnFinish != null)
        //        {
        //            actionName = "PositiveFeedback";
        //            if (Convert.ToString(formCollection["FormCompleted"]) == "on") isFormCompleted = true;
        //            if (Convert.ToString(formCollection["ComplementsFedBack"]) == "on") isComplementsFedBack = true;
        //            int retVal = dBEngine.UpdatePositiveFeedback(isFormCompleted, isComplementsFedBack, formCollection["Comments"], id);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return RedirectToAction(actionName, new { id = id });
        //}


        public ActionResult MeDeclaration(int? id)
        {
            MEDeclaration meDeclaration = new MEDeclaration();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");

            if (id != null)
            {

                meDeclaration = dBEngine.GetMEDeclarationByIdID(id);
                //ViewBag.Diagnoses = dBEngine.GetDiagnosisDetails(id);
                //ViewBag.Procedures = dBEngine.GetProcedureDetails(id);
            }
            else if (id == null || id == 0)
            {
                if (Session["PatientID"] != null)
                    id = Convert.ToInt32(Session["PatientID"]);
                else
                    return RedirectToAction("Index", "Account");
            }

            //meDeclaration.MEName = (Session["FullName"]).ToString();
            //meDeclaration.DclartionDate = System.DateTime.Now;
            //meDeclaration.check = false;
            //meDeclaration.IsConfirmed = false;
            if (Request.HttpMethod != "POST")
            {
            }
            return View(meDeclaration);
        }
        [HttpPost]
        public ActionResult MeDeclaration(FormCollection formCollection, string BtnPrevious, string BtnFinish, string BtnNext, int id, bool IsConfirmed = false)
        {
            bool checkIsConfirmed=false;
            MEDeclaration me ;
            string actionName = "";
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);

            if (!string.IsNullOrEmpty(formCollection["IsConfirmedNo"]))
             {
                string checkResp = formCollection["IsConfirmedNo"];
                if (checkResp == "on")
                {
                    checkIsConfirmed = true;
                }
                else
                {
                    checkIsConfirmed = true;
                }
                if (Session["FullName"] != null)
                {
                    if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                        return RedirectToAction("Index", "Account");
                }
                else
                    return RedirectToAction("Index", "Account");
                try
                {
                    if (id == null || id == 0)
                    {
                        if (Session["PatientID"] != null)
                            id = Convert.ToInt32(Session["PatientID"]);
                        else
                            return RedirectToAction("Index", "Account");
                    }
                    if (BtnPrevious != null)
                        actionName = "PositiveFeedback";
                    if (BtnFinish == null|| BtnFinish == "")
                    {
                        actionName = "MeDeclaration";
                        MEDeclaration mEDeclaration = new MEDeclaration();
                        mEDeclaration.DclartionDate = System.DateTime.Now;
                        mEDeclaration.IsConfirmed = checkIsConfirmed;
                        mEDeclaration.Patient_ID = id.ToString(); 
                        string retval = dBEngine.CheckMEDeclaration(mEDeclaration);

                        int flag = Convert.ToInt32(retval.Split(',')[0]);
                        if (flag == 1)
                        {
                            int len = retval.Split(',').Count();
                            me = new MEDeclaration();
                            me.check = true;
                            me.IsConfirmed = true;
                            //return RedirectToAction(actionName, new { id = id });
                            return View("MeDeclaration", mEDeclaration);

                        }
                        else
                        {
                            int len = retval.Split(',').Count();
                            List<string> array;
                            array = retval.Split(',').ToList();

                            me = new MEDeclaration();
                            me.check = false;
                            me.IsConfirmed = false;
                            //return RedirectToAction(actionName, new { id = id });
                            return View("MeDeclaration", me);
                        }

                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            else if(!string.IsNullOrEmpty(formCollection["IsConfirmedYes"]))
            {
                if (BtnFinish != null)
                {
                    actionName = "MortalityReview";
                    me = new MEDeclaration();
                    me.DclartionDate = System.DateTime.Now;
                    me.IsConfirmed = checkIsConfirmed;
                    me.Patient_ID = id.ToString();
                    int retval1 = dBEngine.insertMEDeclaration(me);

                }

            }
           
         
            return RedirectToAction(actionName, new { id = id });




            //if (Request.HttpMethod != "POST")
            //{
            //}
            //return View();
        }
        public ActionResult NotImplemented()
        {
            return View();
        }

        public ActionResult NotAuthorizedPatientDetails(int? id)
        {
            bool isUser = GetUserDetailsFromAD();
            Session["FullName"] = Session["FirstName"] + " " + Session["LastName"];
            List<clsPatientDetails> patientDetails = new List<clsPatientDetails>();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            Session["PatientID"] = id;


            DBEngine dBEngine = new DBEngine(connectionString);
            dBEngine.LogException("set session id " + id.ToString(), this.ToString(), "ValidateUser", System.DateTime.Now);
            if (id == null || id == 0)
            {
                if (Session["PatientID"] != null)
                    id = Convert.ToInt32(Session["PatientID"]);
                else
                    return RedirectToAction("Index", "Account");
            }
            dBEngine.LogException("after id null and 0 check", this.ToString(), "ValidateUser", System.DateTime.Now);
            try
            {
                patientDetails = dBEngine.GetPatientDetailsByID(id, Convert.ToInt32(Session["LoginUserID"]));
                dBEngine.LogException("after patient details call" + patientDetails.Count.ToString(), this.ToString(), "ValidateUser", System.DateTime.Now);
                if (patientDetails.Count == 0)
                {
                    clsPatientDetails clsPatientDetail = new clsPatientDetails();
                    clsPatientDetail.ID = Convert.ToInt32(id);
                    patientDetails.Add(clsPatientDetail);
                    dBEngine.LogException("in patient details count 0" + clsPatientDetail.ID.ToString(), this.ToString(), "ValidateUser", System.DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            return View(patientDetails[0]);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult CodingReview(int? id)
        {
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");
            bool isUser = GetUserDetailsFromAD();
            List<clsPatientDetails> patientDetails = new List<clsPatientDetails>();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                try
                {
                    if (id != null)
                    {
                        ViewBag.Diagnoses = dBEngine.GetDiagnosisDetails(id);
                        ViewBag.Procedures = dBEngine.GetProcedureDetails(id);

                    }
                    else if (id == null || id == 0)
                    {
                        if (Session["PatientID"] != null)
                            id = Convert.ToInt32(Session["PatientID"]);
                        else
                            return RedirectToAction("Index", "Account");
                    }
                    if (Request.HttpMethod != "POST")
                        patientDetails = dBEngine.GetPatientDetailsByID(id, Convert.ToInt32(Session["LoginUserID"]));
                }
                catch (Exception ex)
                {
                    dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(patientDetails[0]);
        }

        public ActionResult QAPReviewFirstStep(int? id)
        {
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");
            if (id == null || id == 0)
            {
                if (Session["PatientID"] != null)
                    id = Convert.ToInt32(Session["PatientID"]);
                else
                    return RedirectToAction("Index", "Account");
            }
            bool isUser = GetUserDetailsFromAD();
            clsQAPReview qapreview = new clsQAPReview();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                try
                {
                    if (Request.HttpMethod != "POST")
                        qapreview = dBEngine.GetQAPReview(id);
                    if (qapreview.Patient_ID == 0 || qapreview.Patient_ID == null)
                        qapreview.Patient_ID = Convert.ToInt32(id);

                    if (qapreview.QAPReview == 3)
                    {
                        Session["QAPName"] = qapreview.CreatedBy;
                    }
                    else
                    {
                        if (Session["FullName"] != null)
                        {
                            Session["QAPName"] = Session["FullName"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(qapreview);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="btnSave"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CodingReview(FormCollection formCollection, string btnSave, int? id)
        {
            string actionName = "";
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                if (formCollection["CodingIssueIdentified"] == "on") formCollection["CodingIssueIdentified"] = "true"; else formCollection["CodingIssueIdentified"] = "false";
                int retVal = dBEngine.UpdateCodingReview(Convert.ToBoolean(formCollection["CodingIssueIdentified"]), formCollection["Comments"], id);
                actionName = "MortalityReview";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction(actionName, new { id = id });
        }
        [HttpPost]
        public ActionResult QAPReviewFirstStep(FormCollection formCollection, string btnSave, int? id)
        {
            string actionName = "";
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                if (formCollection["MCCD"] == "on") formCollection["MCCD"] = "true"; else formCollection["MCCD"] = "false";
                if (formCollection["Concern"] == "on") formCollection["Concern"] = "true"; else formCollection["Concern"] = "false";
                if (formCollection["Referral"] == "on") formCollection["Referral"] = "true"; else formCollection["Referral"] = "false";
                int retVal = dBEngine.UpdateQAPReview(Convert.ToBoolean(formCollection["MCCD"]), Convert.ToBoolean(formCollection["Referral"]), formCollection["Synopsis"], formCollection["Reason"], formCollection["FullName"],
                    formCollection["GMCNo"], formCollection["Location"], formCollection["Phone"], formCollection["AlternatePhone"], Convert.ToString(Session["FullName"]), DateTime.Now.ToString("dd/MM/yyyy"),
                    Convert.ToBoolean(formCollection["Concern"]), formCollection["Reason1a"], formCollection["Interval1"], formCollection["Reason1b"], formCollection["Interval2"],
                    formCollection["Reason1c"], formCollection["Interval3"], formCollection["Reason2"], formCollection["Interval4"], id);
                actionName = "MortalityReview";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction(actionName, new { id = id });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult SJROutcome(int? id)
        {
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");
            bool isUser = GetUserDetailsFromAD();
            clsSJROutcome sjrOutcome = new clsSJROutcome();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                //if (ApplicationSession.LoginUserID > 0)
                //{
                try
                {
                    if (Request.HttpMethod != "POST")
                    {
                        sjrOutcome = dBEngine.GetSJROutcome(id);
                    }
                    if (sjrOutcome.Patient_ID == 0 || sjrOutcome.Patient_ID == null)
                        sjrOutcome.Patient_ID = Convert.ToInt32(id);
                }
                catch (Exception ex)
                {
                    dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
                }
                //}
                //else
                //{
                //    return RedirectToAction("Index", "Account");
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(sjrOutcome);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="btnSave"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SJROutcome(FormCollection formCollection, string btnSave, int? id)
        {
            string actionName = "";
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                if (formCollection["Stage2SJRRequired"] == "Yes") formCollection["Stage2SJRRequired"] = "true"; else formCollection["Stage2SJRRequired"] = "false";
                if (formCollection["MSGRequired"] == "Yes") formCollection["MSGRequired"] = "true"; else formCollection["MSGRequired"] = "false";
                if (formCollection["Stage2SJRDateSent"] == "") formCollection["Stage2SJRDateSent"] = "";
                if (formCollection["DateReceived"] == "") formCollection["DateReceived"] = "";
                if (formCollection["MSGDiscussionDate"] == "") formCollection["MSGDiscussionDate"] = "";
                if (formCollection["AvoidabilityScoreID"] == "") formCollection["AvoidabilityScoreID"] = "0";
                int retVal = dBEngine.UpdateSJROutcome(Convert.ToBoolean(formCollection["Stage2SJRRequired"]), formCollection["Stage2SJRDateSent"],
                    formCollection["Stage2SJRSentTo"], formCollection["ReferenceNumber"], formCollection["DateReceived"], formCollection["SIRIComments"],
                    Convert.ToBoolean(formCollection["MSGRequired"]), formCollection["MSGDiscussionDate"], Convert.ToInt32(formCollection["AvoidabilityScoreID"]),
                    formCollection["Comments"], formCollection["FeedbackToNoK"], id);
                actionName = "MortalityReview";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction(actionName, new { id = id });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Stage2SJRformFirstStep(int? id)
        {
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");
            bool isUser = GetUserDetailsFromAD();
            clsSJRFormInitial medicalExaminerReview = new clsSJRFormInitial();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                //if (ApplicationSession.LoginUserID > 0)
                //{
                try
                {
                    if (Request.HttpMethod != "POST")
                    {
                        medicalExaminerReview = dBEngine.GetSJRFormInitial(id);
                    }
                    if (medicalExaminerReview.Patient_ID == 0 || medicalExaminerReview.Patient_ID == null)
                        medicalExaminerReview.Patient_ID = Convert.ToInt32(id);
                    ViewBag.ExcellentRatingID = dBEngine.GetRatingIDByName("Excellent");
                    ViewBag.GoodRatingID = dBEngine.GetRatingIDByName("Good");
                    ViewBag.AdequateRatingID = dBEngine.GetRatingIDByName("Adequate");
                    ViewBag.PoorRatingID = dBEngine.GetRatingIDByName("Poor");
                    ViewBag.VeryPoorRatingID = dBEngine.GetRatingIDByName("Very Poor");
                }
                catch (Exception ex)
                {
                    dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
                }
                //}
                //else
                //{
                //    return RedirectToAction("Index", "Account");
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(medicalExaminerReview);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Stage2SJRFormSecondStep(int? id)
        {
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");
            //bool isUser = GetUserDetailsFromAD();
            clsSJRFormProblemType sjrProblemType = new clsSJRFormProblemType();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                //if (ApplicationSession.LoginUserID > 0)
                //{
                try
                {
                    if (Request.HttpMethod != "POST")
                    {
                        sjrProblemType = dBEngine.GetSJRProblemType(id);
                    }
                    if (sjrProblemType.Patient_ID == 0 || sjrProblemType.Patient_ID == null)
                        sjrProblemType.Patient_ID = Convert.ToInt32(id);
                }
                catch (Exception ex)
                {
                    dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
                }
                //}
                //else
                //{
                //    return RedirectToAction("Index", "Account");
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(sjrProblemType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Stage3SJRFormSecondStep(int? id)
        {
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");
            bool isUser = GetUserDetailsFromAD();
            clsSJRFormProblemType sjrProblemType = new clsSJRFormProblemType();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                //if (ApplicationSession.LoginUserID > 0)
                //{
                try
                {
                    if (Request.HttpMethod != "POST")
                    {
                        sjrProblemType = dBEngine.GetSJR2ProblemType(id);
                    }
                    if (sjrProblemType.Patient_ID == 0 || sjrProblemType.Patient_ID == null)
                        sjrProblemType.Patient_ID = Convert.ToInt32(id);
                }
                catch (Exception ex)
                {
                    dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
                }
                //}
                //else
                //{
                //    return RedirectToAction("Index", "Account");
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(sjrProblemType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="BtnNext"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Stage2SJRformFirstStep(FormCollection formCollection, string BtnNext, int? id)
        {
            string actionName = "";
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                int retVal = dBEngine.UpdateSJRFormInitial(formCollection["InitialManagement"], formCollection["hdfInitialManagementCareRating"],
                    formCollection["OngoingCare"], formCollection["hdfOnGoingCareRating"], formCollection["CareDuringProcedure"], formCollection["hdfCareDuringProcedureCareRating"],
                    formCollection["EndLifeCare"], formCollection["hdfEndLifeCareRating"], formCollection["OverAllAssessment"], formCollection["hdfOverAllAssessmentCareRating"],
                    formCollection["hdfQualityDocumentationCareRating"], id);
                actionName = "Stage2SJRFormSecondStep";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction(actionName, new { id = id });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="BtnPrevious"></param>
        /// <param name="BtnFinish"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Stage2SJRformSecondStep(FormCollection formCollection, string BtnPrevious, string BtnFinish, int? id)
        {
            string actionName = "";
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                int PID = Convert.ToInt32(Session["PId"]);
                if (BtnPrevious != null)
                    actionName = "Stage2SJRformFirstStep";
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                if (BtnFinish != null)
                {
                    if (formCollection["hdfProblemOccured"] == "Yes") formCollection["hdfProblemOccured"] = "true"; else formCollection["hdfProblemOccured"] = "false";
                    int retVal = dBEngine.UpdateSJR1ProblemType(Convert.ToInt32(formCollection["AssessmentResponseID"]), Convert.ToInt32(formCollection["AssessmentCarePhaseID"]),
                        Convert.ToInt32(formCollection["MedicationResponseID"]), Convert.ToInt32(formCollection["MedicationCarePhaseID"]), Convert.ToInt32(formCollection["TreatmentResponseID"]),
                        Convert.ToInt32(formCollection["TreatmentCarePhaseID"]), Convert.ToInt32(formCollection["InfectionResponseID"]), Convert.ToInt32(formCollection["InfectionCarePhaseID"]),
                        Convert.ToInt32(formCollection["ProcedureResponseID"]), Convert.ToInt32(formCollection["ProcedureCarePhaseID"]),
                        Convert.ToInt32(formCollection["MonitoringResponseID"]), Convert.ToInt32(formCollection["ResuscitationResponseID"]),
                        Convert.ToInt32(formCollection["OthertypeResponseID"]), Convert.ToInt32(formCollection["OthertypeCarePhaseID"]), Convert.ToInt32(formCollection["AvoidabilityScoreID"]),
                        formCollection["Comments"], formCollection["SIRIComments"], Convert.ToBoolean(formCollection["hdfProblemOccured"]), id);
                    actionName = "MortalityReview";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction(actionName, new { id = id });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Stage3SJRformFirstStep(int? id)
        {
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");
            bool isUser = GetUserDetailsFromAD();
            clsSJRFormInitial medicalExaminerReview = new clsSJRFormInitial();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                //if (ApplicationSession.LoginUserID > 0)
                //{
                try
                {
                    if (Request.HttpMethod != "POST")
                    {
                        medicalExaminerReview = dBEngine.GetSJR2FormInitial(id);
                    }
                    if (medicalExaminerReview.Patient_ID == 0 || medicalExaminerReview.Patient_ID == null)
                        medicalExaminerReview.Patient_ID = Convert.ToInt32(id);
                    ViewBag.ExcellentRatingID = dBEngine.GetRatingIDByName("Excellent");
                    ViewBag.GoodRatingID = dBEngine.GetRatingIDByName("Good");
                    ViewBag.AdequateRatingID = dBEngine.GetRatingIDByName("Adequate");
                    ViewBag.PoorRatingID = dBEngine.GetRatingIDByName("Poor");
                    ViewBag.VeryPoorRatingID = dBEngine.GetRatingIDByName("Very Poor");
                }
                catch (Exception ex)
                {
                    dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
                }
                //}
                //else
                //{
                //    return RedirectToAction("Index", "Account");
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(medicalExaminerReview);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="BtnNext"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Stage3SJRformFirstStep(FormCollection formCollection, string BtnNext, int? id)
        {
            string actionName = "";
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                int retVal = dBEngine.UpdateSJR2FormInitial(formCollection["InitialManagement"], formCollection["hdfInitialManagementCareRating"],
                    formCollection["OngoingCare"], formCollection["hdfOnGoingCareRating"], formCollection["CareDuringProcedure"], formCollection["hdfCareDuringProcedureCareRating"],
                    formCollection["EndLifeCare"], formCollection["hdfEndLifeCareRating"], formCollection["OverAllAssessment"], formCollection["hdfOverAllAssessmentCareRating"],
                    formCollection["hdfQualityDocumentationCareRating"], id);
                actionName = "Stage3SJRFormSecondStep";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction(actionName, new { id = id });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="BtnPrevious"></param>
        /// <param name="BtnFinish"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Stage3SJRformSecondStep(FormCollection formCollection, string BtnPrevious, string BtnFinish, int? id)
        {
            string actionName = "";
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                int PID = Convert.ToInt32(Session["PId"]);
                if (BtnPrevious != null)
                    actionName = "Stage3SJRformFirstStep";
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }

                if (BtnFinish != null)
                {
                    if (formCollection["hdfProblemOccured"] == "Yes") formCollection["hdfProblemOccured"] = "true"; else formCollection["hdfProblemOccured"] = "false";
                    int retVal = dBEngine.UpdateSJR2ProblemType(Convert.ToInt32(formCollection["AssessmentResponseID"]), Convert.ToInt32(formCollection["AssessmentCarePhaseID"]),
                        Convert.ToInt32(formCollection["MedicationResponseID"]), Convert.ToInt32(formCollection["MedicationCarePhaseID"]), Convert.ToInt32(formCollection["TreatmentResponseID"]),
                        Convert.ToInt32(formCollection["TreatmentCarePhaseID"]), Convert.ToInt32(formCollection["InfectionResponseID"]), Convert.ToInt32(formCollection["InfectionCarePhaseID"]),
                        Convert.ToInt32(formCollection["ProcedureResponseID"]), Convert.ToInt32(formCollection["ProcedureCarePhaseID"]),
                        Convert.ToInt32(formCollection["MonitoringResponseID"]), Convert.ToInt32(formCollection["ResuscitationResponseID"]),
                        Convert.ToInt32(formCollection["OthertypeResponseID"]), Convert.ToInt32(formCollection["OthertypeCarePhaseID"]), Convert.ToInt32(formCollection["AvoidabilityScoreID"]),
                        formCollection["Comments"], formCollection["SIRIComments"], Convert.ToBoolean(formCollection["hdfProblemOccured"]), id);
                    actionName = "MortalityReview";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction(actionName, new { id = id });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult PatientDetails(int? id)
        {
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");
            bool isUser = GetUserDetailsFromAD();
            List<clsPatientDetails> patientDetails = new List<clsPatientDetails>();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                //if (ApplicationSession.LoginUserID > 0)
                //{
                try
                {
                    if (id != null)
                    {
                        ViewBag.Diagnoses = dBEngine.GetDiagnosisDetails(id);
                        ViewBag.Procedures = dBEngine.GetProcedureDetails(id);
                    }
                    else if (id == null || id == 0)
                    {
                        if (Session["PatientID"] != null)
                            id = Convert.ToInt32(Session["PatientID"]);
                        else
                            return RedirectToAction("Index", "Account");
                    }
                    if (Request.HttpMethod != "POST")
                    {
                        patientDetails = dBEngine.GetPatientDetailsByID(id, Convert.ToInt32(Session["LoginUserID"]));
                        if (patientDetails.ToList()[0].lstNEXTKin.ToList().Count > 0)
                        {
                            for (int item = 0; item < patientDetails.ToList()[0].lstNEXTKin.ToList().Count; item++)
                            {
                                NextOfKin n = new NextOfKin();
                                n = patientDetails.ToList()[0].lstNEXTKin.ToList()[item];
                                if (item == 0)
                                {
                                    patientDetails.ToList()[0].RelativeName = n.RelativeName;
                                    patientDetails.ToList()[0].RelativeTelNo = n.RelativeTelNo;
                                    patientDetails.ToList()[0].Relationship = n.Relationship;
                                    patientDetails.ToList()[0].PresentAtDeath = n.PresentAtDeath;
                                    patientDetails.ToList()[0].IsInformed = n.IsInformed;
                                    patientDetails.ToList()[0].KinId = n.NextOfKinID;

                                }
                                else if (item == 1)
                                {
                                    patientDetails.ToList()[0].RelativeName1 = n.RelativeName;
                                    patientDetails.ToList()[0].RelativeTelNo1 = n.RelativeTelNo;
                                    patientDetails.ToList()[0].Relationship1 = n.Relationship;
                                    patientDetails.ToList()[0].PresentAtDeath1 = n.PresentAtDeath;
                                    patientDetails.ToList()[0].IsInformed1 = n.IsInformed;
                                    patientDetails.ToList()[0].KinId1 = n.NextOfKinID;
                                }
                                else if (item == 2)
                                {
                                    patientDetails.ToList()[0].RelativeName2 = n.RelativeName;
                                    patientDetails.ToList()[0].RelativeTelNo2 = n.RelativeTelNo;
                                    patientDetails.ToList()[0].Relationship2 = n.Relationship;
                                    patientDetails.ToList()[0].PresentAtDeath2 = n.PresentAtDeath;
                                    patientDetails.ToList()[0].IsInformed2 = n.IsInformed;
                                    patientDetails.ToList()[0].KinId2 = n.NextOfKinID;
                                }
                                else
                                { }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (patientDetails.Count > 0)
            {
                if (patientDetails[0].UserRole.Trim().ToUpper().Equals("ME") || patientDetails[0].UserRole.ToUpper().Trim().Equals("ADMIN"))
                    return View(patientDetails[0]);
                else
                    return RedirectToAction("NotAuthorizedPatientDetails", new { id = id });
            }
            else
                return RedirectToAction("NotAuthorizedPatientDetails", new { id = id });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="btnCloseYes"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult PatientDetails(FormCollection formCollection, string btnCloseYes, int? id)
        {
            List<clsPatientDetails> patientDetails = new List<clsPatientDetails>();
            bool isDataQualityIssuesIdentified = false;
            bool isUrgentMEReview = false;
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dbEngine = new DBEngine(connectionString);
            NextOfKin nextOfKin;
            if (id == null || id == 0)
            {
                if (Session["PatientID"] != null)
                    id = Convert.ToInt32(Session["PatientID"]);
                else
                    return RedirectToAction("Index", "Account");
            }
            try
            {
                if (Convert.ToString(formCollection["DataQualityIssuesIdentified"]) == "on") isDataQualityIssuesIdentified = true;
                if (Convert.ToString(formCollection["UrgentMEReview"]) == "on") isUrgentMEReview = true;
                nextOfKin = new NextOfKin();
                if (formCollection["RelativeName"] != "" && formCollection["RelativeTelNo"] != "" && formCollection["Relationship"] != "")
                {
                    nextOfKin.NextOfKinID = Convert.ToInt32(formCollection["KinId"]);
                    nextOfKin.RelativeName = (formCollection["RelativeName"]).ToString();
                    nextOfKin.RelativeTelNo = (formCollection["RelativeTelNo"]).ToString();
                    nextOfKin.Relationship = formCollection["Relationship"];
                    nextOfKin.PresentAtDeath = Convert.ToBoolean(formCollection["PresentAtDeath"].Split(',')[0]);
                    nextOfKin.IsInformed = Convert.ToBoolean(formCollection["IsInformed"].Split(',')[0]);
                    nextOfKin.PatientID = id.ToString();
                    nextOfKin.NextOfKinID = dbEngine.insertKin(nextOfKin);
                    if (nextOfKin.NextOfKinID > 0)
                    {
                        nextOfKin = new NextOfKin();
                        if (formCollection["RelativeName1"] != "" && formCollection["RelativeTelNo1"] != "" && formCollection["Relationship1"] != "")
                        {
                            nextOfKin.NextOfKinID = Convert.ToInt32(formCollection["KinId1"]);
                            nextOfKin.RelativeName = (formCollection["RelativeName1"]).ToString();
                            nextOfKin.RelativeTelNo = (formCollection["RelativeTelNo1"]).ToString();
                            nextOfKin.Relationship = formCollection["Relationship1"];
                            nextOfKin.PresentAtDeath = Convert.ToBoolean(formCollection["PresentAtDeath1"].Split(',')[0]);
                            nextOfKin.IsInformed = Convert.ToBoolean(formCollection["IsInformed1"].Split(',')[0]);
                            nextOfKin.PatientID = id.ToString();
                            nextOfKin.NextOfKinID = dbEngine.insertKin(nextOfKin);
                            if (nextOfKin.NextOfKinID > 0)
                            {
                                nextOfKin = new NextOfKin();
                                if (formCollection["RelativeName2"] != "" && formCollection["RelativeTelNo2"] != "" && formCollection["Relationship2"] != "")
                                {
                                    nextOfKin.NextOfKinID = Convert.ToInt32(formCollection["KinId2"]);
                                    nextOfKin.RelativeName = (formCollection["RelativeName2"]).ToString();
                                    nextOfKin.RelativeTelNo = (formCollection["RelativeTelNo2"]).ToString();
                                    nextOfKin.Relationship = formCollection["Relationship2"];
                                    nextOfKin.PresentAtDeath = Convert.ToBoolean(formCollection["PresentAtDeath2"].Split(',')[0]);
                                    nextOfKin.IsInformed = Convert.ToBoolean(formCollection["IsInformed2"].Split(',')[0]);
                                    nextOfKin.PatientID = id.ToString();
                                    nextOfKin.NextOfKinID = dbEngine.insertKin(nextOfKin);
                                }
                            }
                        }
                    }

                }

                int retVal = dbEngine.UpdatePatientDetails(isDataQualityIssuesIdentified, formCollection["DataQualityIssueComments"], false, "", formCollection["Occupation"],
                    isUrgentMEReview, formCollection["UrgentMEReviewComment"], formCollection["RelativeName"], formCollection["RelativeTelNo"], formCollection["Relationship"],
                    formCollection["GPSurgery"], id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("MedicalExaminerReview", new { id = id });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult MedicalExaminerReview(int? id)
        {
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");
            //bool isUser = GetUserDetailsFromAD();
            clsMedicalExaminerReview medicalExaminerReview = new clsMedicalExaminerReview();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                //if (ApplicationSession.LoginUserID > 0)
                //{
                try
                {
                    ViewBag.MedicalExaminers = dBEngine.GetMedicalExaminers();
                    ViewBag.CommentType = dBEngine.GetCommentType();
                    ViewBag.Comments = dBEngine.GetComments(id);

                    foreach (var b in ViewBag.CommentType)
                    {
                        foreach (var a in ViewBag.Comments)
                        {
                            if (a.CommentTypeID == b.CommonTypeID)
                            {
                                a.CommentType = b.Type;
                            }
                        }
                    }

                    TempData["Role"] = Session["Role"];
                    if (Request.HttpMethod != "POST")
                    {
                        medicalExaminerReview = dBEngine.GetMedicalExaminerReview(id);
                    }
                    if (medicalExaminerReview.Patient_ID == 0 || medicalExaminerReview.Patient_ID == null)
                        medicalExaminerReview.Patient_ID = Convert.ToInt32(id);
                }
                catch (Exception ex)
                {
                    dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(medicalExaminerReview);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupid"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GetReferralReasons(int? groupid)
        {
            List<clsCoronerReferralReason> referralReasons = new List<clsCoronerReferralReason>();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                referralReasons = dBEngine.GetCoronerReferralReasons(groupid);
                ViewBag.CoronerReferralReasons = referralReasons;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Json(referralReasons, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="BtnPrevious"></param>
        /// <param name="BtnNext"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult MedicalExaminerReview(FormCollection formCollection, string BtnPrevious, string BtnNext, int? id)
        {
            int commentTypeID = 0;
            if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                return RedirectToAction("Index", "Account");
            string actionName = "";
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                bool isQAP_Discussion = false;
                bool isNotes_Review = false;
                bool isNok_Discussion = false;

                if (BtnPrevious != null)
                    actionName = "PatientDetails";
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                if (BtnNext != null)
                {
                    ViewBag.MedicalExaminers = dBEngine.GetMedicalExaminers();
                    if (Convert.ToString(formCollection["QAP_Discussion"]) == "on") isQAP_Discussion = true;
                    if (Convert.ToString(formCollection["Notes_Review"]) == "on") isNotes_Review = true;
                    if (Convert.ToString(formCollection["Nok_Discussion"]) == "on") isNok_Discussion = true;
                    if (formCollection["ddlDischargeSpeciality"] == "") formCollection["ddlDischargeSpeciality"] = "0";
                    if (formCollection["QAPName"] == "") formCollection["QAPName"] = "0";


                    string role = Convert.ToString(formCollection["ddlRole"]);
                    if (formCollection["ddlCommentType"] != "")
                    {
                        commentTypeID = Convert.ToInt32(formCollection["ddlCommentType"]);
                    }
                    else
                    {
                        commentTypeID = 0;
                    }
                    
                    Console.WriteLine(role);
                    Console.WriteLine(commentTypeID);

                    //int retVal = dBEngine.UpdateMedicalExaminerReview(isQAP_Discussion, isNotes_Review, isNok_Discussion,
                    //   Convert.ToInt32(formCollection["ddlDischargeSpeciality"]), formCollection["QAPName"], formCollection["Comments"], id, Convert.ToInt32(Session["LoginUserID"]));

                    int retVal = dBEngine.UpdateMedicalExaminerReview(isQAP_Discussion, isNotes_Review, isNok_Discussion,
                        Convert.ToInt32(formCollection["ddlDischargeSpeciality"]), formCollection["QAPName"], formCollection["Comments"], id, Convert.ToInt32(Session["LoginUserID"]), commentTypeID);
                    actionName = "MedicalExaminerDecision";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction(actionName, new { id = id });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult MedicalExaminerDecision(int? id)
        {
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");
            bool isUser = GetUserDetailsFromAD();
            clsMedicalExaminerDecision medicalExaminerDecision = new clsMedicalExaminerDecision();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                try
                {
                    medicalExaminerDecision = dBEngine.GetMedicalExaminerDecision(id);
                    medicalExaminerDecision.a = "1a";
                    medicalExaminerDecision.b = "1b";
                    medicalExaminerDecision.c = "1c";
                    medicalExaminerDecision.d = "1d";
                    if (medicalExaminerDecision.ID == 0 || medicalExaminerDecision.ID == null)
                        medicalExaminerDecision.ID = Convert.ToInt32(id);
                    //ViewBag.ReasonGroups = dBEngine.GetReasonGroups();
                }
                catch (Exception ex)
                {
                    dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(medicalExaminerDecision);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="BtnPrevious"></param>
        /// <param name="BtnNext"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult MedicalExaminerDecision(FormCollection formCollection, string BtnPrevious, string BtnNext, int id)
        {
            bool isMCCDissue = false;
            bool isCoronerReferral = false;
            bool isHospitalPostMortem = false;
            bool isDeathCertificate = false;
            bool isCornerReferralComplete = false;
            bool isCoronerDecisionInquest = false;
            bool isCoronerDecisionPostMortem = false;
            bool isCoronerDecision100A = false;
            bool isCoronerDecisionGPissue = false;
            string actionName = "";
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            DateTime? deathCertificateDate = null;
            if (id == null || id == 0)
            {
                if (Session["PatientID"] != null)
                    id = Convert.ToInt32(Session["PatientID"]);
                else
                    return RedirectToAction("Index", "Account");
            }
            try
            {
                if (BtnPrevious != null)
                    actionName = "MedicalExaminerReview";
                if (BtnNext != null)
                {
                    actionName = "SJRAssessmentTriage";
                    if (Convert.ToString(formCollection["IssueMCCD"]) == "on") isMCCDissue = true;
                    if (Convert.ToString(formCollection["CoronerReferral"]) == "on") isCoronerReferral = true;
                    if (Convert.ToString(formCollection["PostMortem"]) == "on") isHospitalPostMortem = true;
                    if (Convert.ToString(formCollection["DeathCertificate"]) == "on") isDeathCertificate = true;
                    if (Convert.ToString(formCollection["CoronerReferralComplete"]) == "on") isCornerReferralComplete = true;
                    if (Convert.ToString(formCollection["Inquest"]) == "on") isCoronerDecisionInquest = true;
                    if (Convert.ToString(formCollection["Post-Mortem"]) == "on") isCoronerDecisionPostMortem = true;
                    if (Convert.ToString(formCollection["100A"]) == "on") isCoronerDecision100A = true;
                    if (Convert.ToString(formCollection["GPIssue"]) == "on") isCoronerDecisionGPissue = true;
                    if (isDeathCertificate == true)
                    {
                        if (formCollection["DeathCertificateDate"] != "") deathCertificateDate = DateTime.ParseExact(Convert.ToDateTime(formCollection["DeathCertificateDate"]).ToString("dd/MM/yyyy"), "dd/MM/yyyy", null);
                        //if (formCollection["DeathCertificateTime"] == "") formCollection["DeathCertificateTime"] = DateTime.ParseExact("00:00", "HH:mm", null).ToString();
                    }
                    else
                    {
                        deathCertificateDate = null;
                        formCollection["DeathCertificateTime"] = "";
                        formCollection["TimeType"] = "0";
                    }
                    int retVal = dBEngine.UpdateMedicalExaminerDecision(isMCCDissue, isCoronerReferral, isHospitalPostMortem, isDeathCertificate, isCornerReferralComplete, isCoronerDecisionInquest, isCoronerDecisionPostMortem,
                       isCoronerDecision100A, isCoronerDecisionGPissue, formCollection["CoronerReferralReason"], formCollection["CauseOfDeath1"], formCollection["CauseOfDeath2"], formCollection["CauseOfDeath3"],
                       formCollection["CauseOfDeath4"], deathCertificateDate, formCollection["DeathCertificateTime"], formCollection["TimeType"], id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction(actionName, new { id = id });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult SJRAssessmentTriage(int? id)
        {
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");
            bool isUser = GetUserDetailsFromAD();
            clsSJRReview sJRAssement = new clsSJRReview();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                //if (ApplicationSession.LoginUserID > 0)
                //{
                try
                {
                    sJRAssement = dBEngine.GetSJRAssesmentTraige(id);
                    if (sJRAssement.Patient_ID == 0 || sJRAssement.Patient_ID == null)
                        sJRAssement.Patient_ID = Convert.ToInt32(id);
                    ViewBag.Specialities = dBEngine.GetSpecialitiesForDropDown();
                }
                catch (Exception ex)
                {
                    dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
                }
                //}
                //else
                //{
                //    return RedirectToAction("Index", "Account");
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(sJRAssement);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="BtnPrevious"></param>
        /// <param name="BtnNext"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SJRAssessmentTriage(FormCollection formCollection, string BtnPrevious, string BtnNext, int? id)
        {
            string actionName = "";
            bool isPaediatricPatient = false;
            bool isLearningDisabilityPatient = false;
            bool isMentalillnessPatient = false;
            bool isElectiveAdmission = false;
            bool isNoKConcernsDeath = false;
            bool isOtherConcern = false;
            bool isFullSJRRequired = false;
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                //if (ApplicationSession.LoginUserID > 0)
                //{
                try
                {
                    if (BtnPrevious != null)
                    {
                        actionName = "MedicalExaminerDecision";
                    }
                    if (BtnNext != null)
                    {
                        actionName = "OtherReferrals";
                        if (Convert.ToString(formCollection["PaediatricPatient"]) == "on") isPaediatricPatient = true;
                        if (Convert.ToString(formCollection["LearningDisabilityPatient"]) == "on") isLearningDisabilityPatient = true;
                        if (Convert.ToString(formCollection["MentalillnessPatient"]) == "on") isMentalillnessPatient = true;
                        if (Convert.ToString(formCollection["ElectiveAdmission"]) == "on") isElectiveAdmission = true;
                        if (Convert.ToString(formCollection["NoKConcernsDeath"]) == "on") isNoKConcernsDeath = true;
                        if (Convert.ToString(formCollection["OtherConcern"]) == "on") isOtherConcern = true;
                        if (Convert.ToString(formCollection["FullSJRRequired"]) == "on") isFullSJRRequired = true;
                        int retVal = dBEngine.UpdateSJRAssessmentTriage(isPaediatricPatient, isLearningDisabilityPatient, isMentalillnessPatient, isElectiveAdmission, isNoKConcernsDeath, isOtherConcern, isFullSJRRequired,
                           formCollection["OtherConcernDetails"], Convert.ToInt32(formCollection["ddlCoronerReferral"]), id);
                    }
                }
                catch (Exception ex)
                {
                    dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
                }
                return RedirectToAction(actionName, new { id = id });
                //}
                //else
                //{
                //    return RedirectToAction("Index", "Account");
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get Other referral details for a particular patient ID
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ActionResult</returns>
        public ActionResult OtherReferrals(int? id)
        {
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");
            bool isUser = GetUserDetailsFromAD();
            clsOtherReferralModel sJRAssement = new clsOtherReferralModel();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                //if (ApplicationSession.LoginUserID > 0)
                //{
                try
                {
                    sJRAssement = dBEngine.GetOtherReferrals(id);
                    if (sJRAssement.Patient_ID == 0 || sJRAssement.Patient_ID == null)
                        sJRAssement.Patient_ID = Convert.ToInt32(id);
                }
                catch (Exception ex)
                {
                    dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
                }
                //}
                //else
                //{
                //    return RedirectToAction("Index", "Account");
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(sJRAssement);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="BtnPrevious"></param>
        /// <param name="BtnNext"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult OtherReferrals(FormCollection formCollection, string BtnPrevious, string BtnNext, int? id)
        {
            string actionName = "";
            bool isPatientSafetySIRI = false;
            bool isChildDeathCoordinator = false;
            bool isLearningDisabilityNurse = false;
            bool isHeadOfCompliance = false;
            bool isPALsComplaints = false;
            bool isWardTeam = false;
            bool isOther = false;
            bool isSafeGuard = false;
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);

            try
            {
                if (id == null || id == 0)
                {
                    if (Session["PatientID"] != null)
                        id = Convert.ToInt32(Session["PatientID"]);
                    else
                        return RedirectToAction("Index", "Account");
                }
                if (BtnPrevious != null)
                {
                    actionName = "SJRAssessmentTriage";
                }
                if (BtnNext != null)
                {
                    actionName = "PositiveFeedback";
                    if (Convert.ToString(formCollection["PatientSafetySIRI"]) == "on") isPatientSafetySIRI = true;
                    if (Convert.ToString(formCollection["ChildDeathCoordinator"]) == "on") isChildDeathCoordinator = true;
                    if (Convert.ToString(formCollection["LearningDisabilityNurse"]) == "on") isLearningDisabilityNurse = true;
                    if (Convert.ToString(formCollection["HeadOfCompliance"]) == "on") isHeadOfCompliance = true;
                    if (Convert.ToString(formCollection["PALsComplaints"]) == "on") isPALsComplaints = true;
                    if (Convert.ToString(formCollection["WardTeam"]) == "on") isWardTeam = true;
                    if (Convert.ToString(formCollection["Other"]) == "on") isOther = true;
                    if (Convert.ToString(formCollection["SafeGuard"]) == "on") isSafeGuard = true;
                    int retVal = dBEngine.UpdateOtherReferrals(isPatientSafetySIRI, isChildDeathCoordinator, isLearningDisabilityNurse, isHeadOfCompliance, isPALsComplaints, isWardTeam, isOther,
                       formCollection["PatientSafetySIRIReason"], formCollection["HeadOfComplianceReason"], formCollection["PALsComplaintsReason"], formCollection["WardTeamReason"], formCollection["OtherReason"], isSafeGuard, id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction(actionName, new { id = id });
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="btnSearch"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult MedicalExaminerDashboard(FormCollection formCollection, string btnSearch, int? id, bool qapreview, bool medtriage)
        {
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");


            bool isUser = GetUserDetailsFromAD();
            List<clsPatientDetails> patientDetails = new List<clsPatientDetails>();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            bool isSession = true;
            if (Convert.ToInt32(Session["LoginUserID"]) > 0)
            {
                try
                {
                    ViewBag.LoadDischargeSpecialityDropdown = dBEngine.GetSpecialities();
                    ViewBag.wardDeathDropdown = dBEngine.GetWardOfDeaths();
                    ViewBag.dischargeConsultantDropdown = dBEngine.GetConsultants();
                    ViewBag.PatientTypeDDM = dBEngine.GetPatientTypes();
                    if (Request.HttpMethod != "POST")
                    {
                        if (Session["StartDate"] == null)
                        {
                            Session["StartDate"] = DateTime.Now.AddDays(-30).ToString("dd/MM/yyyy");
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        else if (Convert.ToString(Session["StartDate"]) == "")
                        {
                            Session["StartDate"] = DateTime.Now.AddDays(-30).ToString("dd/MM/yyyy");
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        if (Session["EndDate"] == null)
                        {
                            Session["EndDate"] = DateTime.Now.ToString("dd/MM/yyyy");
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        else if (Convert.ToString(Session["EndDate"]) == "")
                        {
                            Session["EndDate"] = DateTime.Now.ToString("dd/MM/yyyy");
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        if (Session["WardDeath"] == null)
                        {
                            Session["WardDeath"] = "0";
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        else if (Convert.ToString(Session["WardDeath"]) == "")
                        {
                            Session["WardDeath"] = "0";
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        if (Session["PatientType"] == null)
                        {
                            Session["PatientType"] = "0";
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        else if (Convert.ToString(Session["PatientType"]) == "")
                        {
                            Session["PatientType"] = "0";
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        if (Session["DischargeConsultant"] == null)
                        {
                            Session["DischargeConsultant"] = "0";
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        else if (Convert.ToString(Session["DischargeConsultant"]) == "")
                        {
                            Session["DischargeConsultant"] = "0";
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        if (Session["Speciality"] == null)
                        {
                            Session["Speciality"] = "0";
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        else if (Convert.ToString(Session["Speciality"]) == "")
                        {
                            Session["Speciality"] = "0";
                            Session.Timeout = 30;
                            isSession = false;
                        }

                        if (isSession && qapreview == false && medtriage == false)
                        {
                            patientDetails = dBEngine.GetFilteredPatientDetails(DateTime.ParseExact(Session["StartDate"].ToString(), "dd/MM/yyyy", null), DateTime.ParseExact(Session["EndDate"].ToString(), "dd/MM/yyyy", null), Convert.ToString(Session["DischargeConsultant"]),
                            Convert.ToString(Session["WardDeath"]), Convert.ToString(Session["Speciality"]), Convert.ToString(Session["PatientType"]));
                            Session["TotalDeaths"] = patientDetails.Count;
                        }
                        else if (isSession && qapreview && !medtriage)
                        {
                            patientDetails = dBEngine.GetPatientDetailsByQAP(id, Convert.ToInt32(Session["LoginUserID"]), DateTime.ParseExact(Session["StartDate"].ToString(), "dd/MM/yyyy", null), DateTime.ParseExact(Session["EndDate"].ToString(), "dd/MM/yyyy", null), Convert.ToString(Session["DischargeConsultant"]),
                            Convert.ToString(Session["WardDeath"]), Convert.ToString(Session["Speciality"]), Convert.ToString(Session["PatientType"]));
                        }
                        else if (isSession && !qapreview && medtriage)
                        {
                            patientDetails = dBEngine.GetPatientDetailsByMedTriage(id, Convert.ToInt32(Session["LoginUserID"]), DateTime.ParseExact(Session["StartDate"].ToString(), "dd/MM/yyyy", null), DateTime.ParseExact(Session["EndDate"].ToString(), "dd/MM/yyyy", null), Convert.ToString(Session["DischargeConsultant"]),
                            Convert.ToString(Session["WardDeath"]), Convert.ToString(Session["Speciality"]), Convert.ToString(Session["PatientType"]));
                        }
                        else
                        {
                            patientDetails = dBEngine.GetPatientDetails(id, Convert.ToInt32(Session["LoginUserID"]));
                            Session["TotalDeaths"] = patientDetails.Count;
                        }
                    }
                    else
                    {
                        if (formCollection["txtStartDate"] == "")
                            formCollection["txtStartDate"] = DateTime.Now.AddDays(-30).ToString("dd/MM/yyyy");
                        else
                            formCollection["txtStartDate"] = formCollection["txtStartDate"].Replace("-", "/");
                        if (formCollection["txtEndDate"] == "")
                            formCollection["txtEndDate"] = DateTime.Now.ToString("dd/MM/yyyy");
                        else
                            formCollection["txtEndDate"] = formCollection["txtEndDate"].Replace("-", "/");
                        Session["StartDate"] = formCollection["txtStartDate"];
                        Session.Timeout = 30;
                        Session["EndDate"] = formCollection["txtEndDate"];
                        Session.Timeout = 30;
                        Session["DischargeConsultant"] = formCollection["ddlDischargeConsultant"];
                        Session.Timeout = 30;
                        Session["WardDeath"] = formCollection["ddlWardDeath"];
                        Session.Timeout = 30;
                        Session["Speciality"] = formCollection["ddlDischargeSpeciality"];
                        Session.Timeout = 30;
                        Session["PatientType"] = formCollection["ddlPatientType"];
                        Session.Timeout = 30;
                        if (Session["StartDate"] == null)
                        {
                            Session["StartDate"] = DateTime.Now.AddDays(-30).ToString("dd/MM/yyyy");
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        else if (Convert.ToString(Session["StartDate"]) == "")
                        {
                            Session["StartDate"] = DateTime.Now.AddDays(-30).ToString("dd/MM/yyyy");
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        if (Session["EndDate"] == null)
                        {
                            Session["EndDate"] = DateTime.Now.ToString("dd/MM/yyyy");
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        else if (Convert.ToString(Session["EndDate"]) == "")
                        {
                            Session["EndDate"] = DateTime.Now.ToString("dd/MM/yyyy");
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        if (Session["WardDeath"] == null)
                        {
                            Session["WardDeath"] = "0";
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        else if (Convert.ToString(Session["WardDeath"]) == "")
                        {
                            Session["WardDeath"] = "0";
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        if (Session["DischargeConsultant"] == null)
                        {
                            Session["DischargeConsultant"] = "0";
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        else if (Convert.ToString(Session["DischargeConsultant"]) == "")
                        {
                            Session["DischargeConsultant"] = "0";
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        if (Session["PatientType"] == null)
                        {
                            Session["PatientType"] = "0";
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        else if (Convert.ToString(Session["PatientType"]) == "")
                        {
                            Session["PatientType"] = "0";
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        if (Session["Speciality"] == null)
                        {
                            Session["Speciality"] = "0";
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        else if (Convert.ToString(Session["Speciality"]) == "")
                        {
                            Session["Speciality"] = "0";
                            Session.Timeout = 30;
                            isSession = false;
                        }
                        if (qapreview)
                        {
                            patientDetails = dBEngine.GetPatientDetailsByQAP(id, Convert.ToInt32(Session["LoginUserID"]), DateTime.ParseExact(formCollection["txtStartDate"], "dd/MM/yyyy", null), DateTime.ParseExact(formCollection["txtEndDate"], "dd/MM/yyyy", null), formCollection["ddlDischargeConsultant"],
                                formCollection["ddlWardDeath"], formCollection["ddlDischargeSpeciality"], formCollection["ddlPatientType"]);
                        }
                        else if (medtriage)
                        {
                            patientDetails = dBEngine.GetPatientDetailsByMedTriage(id, Convert.ToInt32(Session["LoginUserID"]), DateTime.ParseExact(formCollection["txtStartDate"], "dd/MM/yyyy", null), DateTime.ParseExact(formCollection["txtEndDate"], "dd/MM/yyyy", null), formCollection["ddlDischargeConsultant"],
                                formCollection["ddlWardDeath"], formCollection["ddlDischargeSpeciality"], formCollection["ddlPatientType"]);
                        }
                        else
                        {
                            patientDetails = dBEngine.GetFilteredPatientDetails(DateTime.ParseExact(formCollection["txtStartDate"], "dd/MM/yyyy", null), DateTime.ParseExact(formCollection["txtEndDate"], "dd/MM/yyyy", null), formCollection["ddlDischargeConsultant"],
                                formCollection["ddlWardDeath"], formCollection["ddlDischargeSpeciality"], formCollection["ddlPatientType"]);
                            Session["TotalDeaths"] = patientDetails.Count;
                        }
                    }
                }
                catch (Exception ex)
                {
                    dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
                    throw ex;
                }
            }
            else
            {
                return RedirectToAction("Index", "Account");
            }
            if (patientDetails.Count > 0)
            {
                Session["QAPCount"] = patientDetails[0].QAPCount;
                Session["MedCount"] = patientDetails[0].MedCount;
                Session.Timeout = 4000;
            }
            else
            {
                Session["QAPCount"] = 0;
                Session["MedCount"] = 0;
                Session.Timeout = 4000;
            }
            //foreach(var a in patientDetails)
            //{
            //    //a.DOB = a.DOB.Date;
            //    a.DOB = (a.DOB);
            //}
            patientDetails = patientDetails.OrderByDescending(a => a.DateofDeath).ToList();
            //Session["TotalDeaths"] = patientDetails.Count;
            return View(patientDetails);
        }

        public ActionResult QAPRedOrAmber(int? id)
        {
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");
            bool isUser = GetUserDetailsFromAD();
            List<clsPatientDetails> patientDetails = new List<clsPatientDetails>();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            if (Convert.ToInt32(Session["LoginUserID"]) > 0)
            {
                try
                {
                    ViewBag.LoadDischargeSpecialityDropdown = dBEngine.GetSpecialities();
                    ViewBag.wardDeathDropdown = dBEngine.GetWardOfDeaths();
                    ViewBag.dischargeConsultantDropdown = dBEngine.GetConsultants();

                }
                catch (Exception ex)
                {
                    dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
                    throw ex;
                }
            }
            else
            {
                return RedirectToAction("Index", "Account");
            }
            return View(patientDetails);
        }

        public ActionResult MedTriageRedOrAmber(int? id)
        {
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");
            bool isUser = GetUserDetailsFromAD();
            List<clsPatientDetails> patientDetails = new List<clsPatientDetails>();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            if (Convert.ToInt32(Session["LoginUserID"]) > 0)
            {
                try
                {
                    ViewBag.LoadDischargeSpecialityDropdown = dBEngine.GetSpecialities();
                    ViewBag.wardDeathDropdown = dBEngine.GetWardOfDeaths();
                    ViewBag.dischargeConsultantDropdown = dBEngine.GetConsultants();

                }
                catch (Exception ex)
                {
                    dBEngine.LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
                    throw ex;
                }
            }
            else
            {
                return RedirectToAction("Index", "Account");
            }
            return View(patientDetails);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult MortalityReview(int? id)
        {
            if (Session["FullName"] != null)
            {
                if (string.IsNullOrEmpty(Session["FullName"].ToString()))
                    return RedirectToAction("Index", "Account");
            }
            else
                return RedirectToAction("Index", "Account");
            bool isUser = GetUserDetailsFromAD();
            Session["PatientID"] = id;
            Session.Timeout = 4000;
            List<clsPatientDetails> patientDetails = new List<clsPatientDetails>();
            string connectionString = ConfigurationManager.ConnectionStrings["NHSConStr"].ConnectionString;
            DBEngine dBEngine = new DBEngine(connectionString);
            //if (ApplicationSession.LoginUserID > 0)
            //{
            if (id == null || id == 0)
            {
                if (Session["PatientID"] != null)
                    id = Convert.ToInt32(Session["PatientID"]);
                else
                    return RedirectToAction("Index", "Account");
            }

            try
            {
                patientDetails = dBEngine.GetPatientDetails(id, Convert.ToInt32(Session["LoginUserID"]));
                ViewBag.PatientHistoryLink = "'" + "http://rbhbedred001/#/views/R550_RBH_Mortality_Reviews/PatientHistory?MRN=" + patientDetails[0].PatientId + ":iid=" + id.ToString() + "'";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //}
            //else
            //{
            //    return RedirectToAction("Index", "Account");
            //}
            return View(patientDetails[0]);
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
            string userName = "";
            try
            {
                //string LDAPUrl = ConfigurationManager.AppSettings["LDAPURL"].ToString();
                userName = Request.ServerVariables["REMOTE_USER"];
                //userName = Environment.GetEnvironmentVariable("USERNAME");
                //dBEngine.LogException("before username", this.ToString(), "ValidateUser", System.DateTime.Now);
                //if (WindowsIdentity.GetCurrent() != null)
                //userName = WindowsIdentity.GetCurrent().Name;
                //else
                //userName = "Nothing found";
                if (string.IsNullOrEmpty(userName))
                    userName = "Nothing found";
                //dBEngine.LogException(userName, this.ToString(), "ValidateUser", System.DateTime.Now);
                //StreamWriter sw = new StreamWriter(@"E:\Publish\log1.txt", true);
                //sw.WriteLine(userName);
                //sw.Close();
                //userName = null;
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
                    Session["FullName"] = Session["FirstName"] + " " + Session["LastName"];
                    Session.Timeout = 4000;
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
                else
                {
                    //AppUsers user = dBEngine.ValidateUser(userName.Split("\\".ToCharArray())[1]);
                    //if (user.IsFound == true)
                    //    isValid = true;
                    //else
                    //    isValid = false;
                    //Session["FullName"] = user.FirstName + " " + user.LastName;
                    Session["FullName"] = Session["FirstName"] + " " + Session["LastName"];
                    Session.Timeout = 4000;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isValid;
        }
    }
}
