using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LearnGlobalization.App_LocalResources;

namespace LearnGlobalization.Models
{
    public class Contact
    {
        [Required(ErrorMessageResourceType = typeof(Contacts),ErrorMessageResourceName = "Please_fill_this_field_in")]
        [EmailAddress(ErrorMessageResourceType = typeof(Contacts),ErrorMessageResourceName = "Please_input_an_email_address")]
        [Display(Name = "EmailAddress", ResourceType = typeof(Contacts))]
        public string EmailAddress { get; set; }

        [Required(ErrorMessageResourceType = typeof(Contacts), ErrorMessageResourceName = "Please_fill_this_field_in")]
        [StringLength(100, ErrorMessageResourceType = typeof(Contacts), ErrorMessageResourceName = "Your_input_is_too_long")]
        [Display(Name = "EmailContent", ResourceType = typeof(Contacts))]
        public string EmailContent { get; set; }
    }
}