﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;
using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;

namespace Vidly.Models
{
    public class Customer
    { 
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

      
        public MembershipType MembershipType { get; set; }

        [Display(Name = "membership Type ")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime?  Birthdate { get; set; }
    }
}