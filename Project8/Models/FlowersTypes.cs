using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLoginWindow3.Tables
{
    public class FlowersTypes
    {
        public string FlowerType { get; set; }

        [Key]
        public string FlowerId{ get; set; }

    }
}
