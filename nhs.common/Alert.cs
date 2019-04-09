using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHS.Common
{
    public class Alert
    {
        public ALERTTYPE AlertType { get; set; }
        private ALERTMESSAGETYPE _messageType = ALERTMESSAGETYPE.TextWithClose;

        public ALERTMESSAGETYPE MessageType
        {
            get
            {
                return _messageType;
            }
            set
            {
                _messageType = value;
            }
        }
        public string Message { get; set; }
    }

    public enum ALERTTYPE
    {
        None,
        Warning,
        Success,
        Info,
        Error
    }

    public enum ALERTMESSAGETYPE
    {
        OnlyText,
        TextWithClose
    }
}
