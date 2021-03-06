﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroupCapstone.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Order Date")]
        public DateTime Date {get; set;}


        [Display (Name = "Total Price")]
        [DisplayFormat(DataFormatString = "{0:c2}", ApplyFormatInEditMode = true)]
        public double TotalPrice { get; set; }

        [Display(Name = "Completed Status")]

        public bool IsCompleted { get; set; }

        [Display (Name = "Picked Status")]
        public bool IsPicked { get; set; }

        [ForeignKey("Customer")]
        [Display (Name = "Customer Id Number")]
        public int CustomerId { get; set; }
		public Customer Customer { get; set; }

        public Order()
        {
            IsCompleted = false;
            IsPicked = false;

        }




    }
}
