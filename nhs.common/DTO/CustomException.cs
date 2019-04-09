using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHS.Common.DTO
{
    public class CustomException
    {
        #region Private Variable Declarations
        private String _errorMessage;
        private String _className;
        private String _methodName;
        private DateTime _createdDate;
        private Object _OtherInformation;
        private String _ErrorTypeCode;
        private bool _IsMobileLog;
        private string _Company;
        private string _VersionName;
        private string _PlatformType;
        private string _DeviceModel;
        private string _DeviceId;

        #endregion

        #region Get/Set Public Variable Properties

        public String ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }

        public String ClassName
        {
            get { return _className; }
            set { _className = value; }
        }

        public String MethodName
        {
            get { return _methodName; }
            set { _methodName = value; }
        }

        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public Object OtherInformation
        {
            get { return _OtherInformation; }
            set { _OtherInformation = value; }
        }

        public String ErrorTypeCode
        {
            get { return _ErrorTypeCode; }
            set { _ErrorTypeCode = value; }
        }

        public bool IsMobileLog
        {
            get { return _IsMobileLog; }
            set { _IsMobileLog = value; }
        }

        public string Company
        {
            get { return _Company; }
            set { _Company = value; }
        }

        public Decimal ErrorNo { get; set; }

        public int TotalRecords { get; set; }

        public string VersionName
        {
            get { return _VersionName; }
            set { _VersionName = value; }
        }
        public string PlatformType
        {
            get { return _PlatformType; }
            set { _PlatformType = value; }
        }
        public string DeviceModel
        {
            get { return _DeviceModel; }
            set { _DeviceModel = value; }
        }
        public string DeviceId
        {
            get { return _DeviceId; }
            set { _DeviceId = value; }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Default CustomException constructor
        /// </summary>
        public CustomException()
        {
            _errorMessage = String.Empty;
            _className = String.Empty;
            _methodName = String.Empty;
            _createdDate = Convert.ToDateTime("01/01/0001");
            _OtherInformation = new Object();
            _ErrorTypeCode = "E";
            _IsMobileLog = false;
            _Company = "";
            VersionName = "";
            PlatformType = "";
            DeviceModel = "";
            DeviceId = "";
        }


        /// <summary>
        /// Parameterized CustomException constructor
        /// </summary>
        /// <param name="ErrorMessage"></param>
        /// <param name="ClassName"></param>
        /// <param name="MethodName"></param>
        /// <param name="CreatedDate"></param>
        public CustomException(String ErrorMessage, String ClassName, String MethodName, DateTime CreatedDate, String ErrorTypeCode = "E", bool IsMobileLog = false, string Company = "", string VersionName = "", string PlatformType = "", string DeviceModel = "", string DeviceId = "")
        {
            _errorMessage = ErrorMessage;
            _className = ClassName;
            _methodName = MethodName;
            _createdDate = CreatedDate;
            _ErrorTypeCode = ErrorTypeCode;
            _IsMobileLog = IsMobileLog;
            _Company = Company;
            _VersionName = VersionName;
            _PlatformType = PlatformType;
            _DeviceModel = DeviceModel;
            _DeviceId = DeviceId;
        }

        /// <summary>
        /// Parameterized CustomException constructor
        /// </summary>
        /// <param name="ErrorMessage"></param>
        /// <param name="ClassName"></param>
        /// <param name="MethodName"></param>
        /// <param name="CreatedDate"></param>
        /// <param name="OtherInformation"></param>
        public CustomException(String ErrorMessage, String ClassName, String MethodName, DateTime CreatedDate, Object OtherInformation, String ErrorTypeCode = "E", bool IsMobileLog = false, string Company = "", string VersionName = "", string PlatformType = "", string DeviceModel = "", string DeviceId = "")
        {
            _errorMessage = ErrorMessage;
            _className = ClassName;
            _methodName = MethodName;
            _createdDate = CreatedDate;
            _OtherInformation = OtherInformation;
            _ErrorTypeCode = ErrorTypeCode;
            _IsMobileLog = IsMobileLog;
            _Company = Company;
            _VersionName = VersionName;
            _PlatformType = PlatformType;
            _DeviceModel = DeviceModel;
            _DeviceId = DeviceId;
        }
        #endregion
    }
}
