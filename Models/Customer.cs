using System;
using System.ComponentModel.DataAnnotations;

namespace ProductOrderCRUD.Models
{
    public class Customer
    {
        public string customerID { get;set; }
        public string cutomerName {get;set;}
        public string address {get;set;}
        public string city {get;set;}
    }
}