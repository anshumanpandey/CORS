using NHS.Common.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHS.Data
{
    /// <summary>
    /// This class is used to log exceptions to the database.
    /// </summary>
    public class ExceptionManager
    {
        #region Public Methods

        /// <summary>
        /// Delegate to log the exception asynchronously
        /// </summary>
        /// <param name="exceptionDTO">CustomException</param>
        public delegate void ErrorDelegate(CustomException exceptionDTO, SqlConnection connection);

        /// <summary>
        /// Method called from across the data access layer to log errors
        /// encountered in the 
        /// </summary>
        /// <param name="exceptionDTO"></param>
        public static void PublishException(CustomException exceptionDTO, SqlConnection connection)
        {
            //Create the delegate
            ErrorDelegate dgtErrors = new ErrorDelegate(SaveErrorMessage);

            //Call the beginInvoke function
            IAsyncResult tag = dgtErrors.BeginInvoke(exceptionDTO, connection, null, null);

            //Calling endInvoke
            dgtErrors.EndInvoke(tag);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Call stored procedure to save the exception log.
        /// </summary>
        /// <param name="exceptionDTO">CustomException</param>
        private static void SaveErrorMessage(CustomException exceptionDTO, SqlConnection connection)
        {
            int iReturn = 0;
            if (string.IsNullOrEmpty(exceptionDTO.ErrorTypeCode))
            {
                exceptionDTO.ErrorTypeCode = "E";
            }

            SqlCommand cmdException = new SqlCommand("usp_save_exceptionlog", connection);

            //default to "E" for error 
            if (exceptionDTO.ErrorTypeCode == "")
            {
                exceptionDTO.ErrorTypeCode = "E";
            }

            cmdException.Parameters.AddWithValue("ErrorMessage", exceptionDTO.ErrorMessage);
            cmdException.Parameters.AddWithValue("ClassName", exceptionDTO.ClassName);
            cmdException.Parameters.AddWithValue("MethodName", exceptionDTO.MethodName);
            cmdException.Parameters.AddWithValue("CreatedDate", exceptionDTO.CreatedDate);
            cmdException.Parameters.AddWithValue("OtherInformation", exceptionDTO.OtherInformation);
            cmdException.Parameters.AddWithValue("ErrorTypeCode", exceptionDTO.ErrorTypeCode);
            cmdException.Parameters.AddWithValue("IsMobileLog", exceptionDTO.IsMobileLog);
            cmdException.Parameters.AddWithValue("VersionName", exceptionDTO.VersionName);
            cmdException.Parameters.AddWithValue("PlatformType", exceptionDTO.PlatformType);
            cmdException.Parameters.AddWithValue("DeviceModel", exceptionDTO.DeviceModel);
            cmdException.Parameters.AddWithValue("DeviceId", exceptionDTO.DeviceId);
            iReturn = cmdException.ExecuteNonQuery();
        }

        #endregion
    }
}
