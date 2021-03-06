﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sb_admin_2.Web.Models
{
    public class NewTaxi
    {
        [Required(ErrorMessage = "Please select Site.")]
        [StringLength(255)]
        //[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter only alphabets.")]
        public string NT_SiteName { get; set; }


        [Required]
        public string NT_TaxiType { get; set; }


        //[Required(ErrorMessage = "Please enter Plate Number")]

        [Key]
        public string NT_PlateNumber { get; set; }


        //[RegularExpression("([1-9][0-9]*)", ErrorMessage = "Must be a number")]
        [Required(ErrorMessage = "Please enter MDVR Number")]
        public string NT_MdvrNo { get; set; }


        [Required(ErrorMessage = "Please enter Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MMM-yyyy hh:mm tt}")]
        public DateTime NT_Date { get; set; }

        [Required]
        public string NT_Region { get; set; }

        //[Required]
        //public string NT_ExistingMDVR { get; set; }


        //[Required(ErrorMessage = "Please enter MDVR Serial No.")]
        //[MaxLength(10, ErrorMessage="Cannot be greater than 10")]
        //public string NT_MDVRSerialNo { get; set; }


        //[Required]
        //public string NT_Cameras { get; set; }

        [Required(ErrorMessage = "Please enter Camera Serial No.")]
        public string NT_CameraSerialNo { get; set; }

        //[Required]
        //public string NT_Ups { get; set; }


        [Required(ErrorMessage = "Please enter UPS Serial No.")]
        public string NT_UpsSerialNo { get; set; }

        //[Required]
        //public string NT_Hdds { get; set; }


        [Required(ErrorMessage = "Please enter HDD Serial No.")]
        public string NT_HDDSerialNo { get; set; }

        //[Required]
        //public string NT_Sims { get; set; }

        [Required]
        public string NT_Emmis { get; set; }

        
        [Required]
        public string NT_CameraConnector { get; set; }

        [Required]
        public string NT_DiskSize { get; set; }

        

        //[Required(ErrorMessage = "Please enter Depot Representative Name.")]
        public bool? Is_NT_DepotRepApproved { get; set; }


        //[Required(ErrorMessage = "Please enter SecureTech Representative Name.")]
        public bool? Is_NT_SecureTechRepApproved { get; set; }


        //[Required(ErrorMessage = "Please enter MCC Representative Name.")]
        public bool? Is_NT_MccRepApproved { get; set; }

        
        //[Required]
        public string User { get; set; }

        public List<Preventive> Preventives { get; set; }

        //public List<SelectListItem> Channels { get; set; }
        
    }

    //public class Channels
    //{
    //    public string Text { get; set; }
    //    public string Value { get; set; }
    //}

}