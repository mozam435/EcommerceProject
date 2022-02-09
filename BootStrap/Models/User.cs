using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BootStrap.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserCity { get; set; }
        public string UserState { get; set; }
        public string UserZip { get; set; }
        public string UserEmailVerified { get; set; }
        public byte[] UserRegisterationDate { get; set; }
        public string UserVerificationCode { get; set; }
        public string UserIp { get; set; }
        public string UserPhone { get; set; }
        public string UserFax { get; set; }
        public string UserCountry { get; set; }
        public string UserAddress { get; set; }
        public string UserAddress2 { get; set; }
        public string UserRole { get; set; }
    }
}
