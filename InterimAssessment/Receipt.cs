using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterimAssessment
{
    public class Receipt
    {
        public int Id { get; set; }
        public string ProdName { get; set; }    

        public double Price { get; set; }   

        public int Quantity { get; set; }

        public string Total { get; set;  }
    }
}