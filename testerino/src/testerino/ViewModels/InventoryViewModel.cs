﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testerino.ViewModels
{
    public class InventoryViewModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Category { get; set; }


        /// <summary>
        /// /////////////////////////////////////////////
        /// </summary>

        //[StringLength(100)]
        //[Display(Name = "Storage Location")]
        //public string StorageLocation { get; set; }


        ////[QuantityValidation]

        //[Range(0, 1000)]
        //[Display(Name = "Total Quantity")]
        //public int TotalQuantity { get; set; }
        ////[Required]
        //[Range(0, 1000)]
        //[Display(Name = "Quantity Remaining")]
        //public int QuantityRemaining { get; set; }


        //[Display(Name = "Request Submitted?")]
        //public Boolean RequestSubmitted { get; set; }
    }
}
