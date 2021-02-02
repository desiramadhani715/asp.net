using System;
using System.ComponentModel.DataAnnotations;

namespace ProductOrderCRUD.Models
{
    public class User
    {
        public string username { get;set; }
        public string password { get;set; }
        public bool isAdmin { get;set; }
        

    }
}