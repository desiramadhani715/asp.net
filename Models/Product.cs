using System;
using System.ComponentModel.DataAnnotations;

namespace ProductOrderCRUD.Models
{
    public class Product
    {
         public string productID { get;set; }

        [Required]  //tdk boleh kosong
        public string namaProduct {get;set;}
        public int price {get;set;}
        

    }
}