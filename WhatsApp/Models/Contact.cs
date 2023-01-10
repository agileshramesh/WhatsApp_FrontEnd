using System;
using System.Collections.Generic;
using System.Text;

namespace WhatsApp.Models
{
    /// <summary>
    /// WhastSapp Contact lass.
    /// ChatMetaData is the last message, date, ... with the currrent contact.
   
    public class Contact
    {
        public long ContactID { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string ProfileImage { get; set; }
        public bool ChatPinned { get; set; }
        public virtual LastChatMetaData ChatMetaData { get; set; }
    }
}
