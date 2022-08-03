using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaymentPortal.Models
{
    public class UsersModel
    {
        public int UserID { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public string PasswordHash { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public bool LockedOut { get; set; }
        public DateTime LockedOutEndDate { get; set; }
        public DateTime UserCreatedDate { get; set; }
        public bool UserIsActive { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserCompany { get; set; }
        public string UserEmail { get; set; }
        public bool UserEmailConfirmed { get; set; }
        public string UserPhoneNumber { get; set; }
        public bool UserPhoneNumberConfirmed { get; set; }
        public string UserBillingAddress1 { get; set; }
        public string UserBillingAddress2 { get; set; }
        public string UserBillingCity { get; set; }
        public string UserBillingState { get; set; }
        public string UserBillingZip { get; set; }
    }
}