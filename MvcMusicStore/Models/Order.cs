using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [MaxWord(2)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public decimal Total { get; set; }
        //public List<OrderDetail> OrderDetails { get; set; }

    }
}