//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JustFood.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.AccountBalances = new HashSet<AccountBalance>();
            this.AccountBalances1 = new HashSet<AccountBalance>();
            this.DetailedSales = new HashSet<DetailedSale>();
            this.Inventories = new HashSet<Inventory>();
            this.InventoryIns = new HashSet<InventoryIn>();
            this.Notifications = new HashSet<Notification>();
            this.NotificationSeens = new HashSet<NotificationSeen>();
            this.Requisitions = new HashSet<Requisition>();
            this.Requisitions1 = new HashSet<Requisition>();
            this.SalaryPaids = new HashSet<SalaryPaid>();
        }
    
        public int UserID { get; set; }
        public string LogName { get; set; }
        public string Name { get; set; }
        public System.DateTime LastLogIn { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsOwner { get; set; }
        public double Percentage { get; set; }
        public double Salary { get; set; }
        public bool IsAccessToAdmin { get; set; }
        public bool IsBlocked { get; set; }
        public short TimeZoneID { get; set; }
        public string Email { get; set; }
        public bool IsValidEmail { get; set; }
    
        public virtual ICollection<AccountBalance> AccountBalances { get; set; }
        public virtual ICollection<AccountBalance> AccountBalances1 { get; set; }
        public virtual ICollection<DetailedSale> DetailedSales { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<InventoryIn> InventoryIns { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<NotificationSeen> NotificationSeens { get; set; }
        public virtual ICollection<Requisition> Requisitions { get; set; }
        public virtual ICollection<Requisition> Requisitions1 { get; set; }
        public virtual ICollection<SalaryPaid> SalaryPaids { get; set; }
        public virtual TimeZone TimeZone { get; set; }
    }
}