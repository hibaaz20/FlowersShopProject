using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HackerU_MidProject2.Tables
{
    public class OrdersDetails
    {
      
        public string UserName { get; set; }
        
  [Key]
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public string ItemColor { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate{ get; set; }
    }
}
