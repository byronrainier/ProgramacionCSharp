//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseManagment.Conceptual
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int productid { get; set; }
        public string productname { get; set; }
        public int categoryid { get; set; }
        public decimal unitprice { get; set; }
        public bool discontinued { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
