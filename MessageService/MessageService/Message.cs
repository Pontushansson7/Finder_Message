//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MessageService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public int Id { get; set; }
        public int SendingUserId { get; set; }
        public int RecievingUserId { get; set; }
        public string Message1 { get; set; }
        public System.DateTime Time { get; set; }
        public int ServiceId { get; set; }
        public string ServiceTitle { get; set; }
        public byte[] UserPicture { get; set; }
    }
}
