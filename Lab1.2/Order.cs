//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab1._2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int ID_Orders { get; set; }
        public decimal Price { get; set; }
        public int Client_ID { get; set; }
        public int Personal_ID { get; set; }
        public int Pizza_ID { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Personal Personal { get; set; }
        public virtual Pizza Pizza { get; set; }
    }
}
