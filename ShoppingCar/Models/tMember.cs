//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoppingCar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class tMember
    {
        public int fId { get; set; }

        [DisplayName("�b��")]
        [Required]
        public string fUserId { get; set; }

        [DisplayName("�K�X")]
        [Required]
        public string fPwd { get; set; }


        [DisplayName("�m�W")]
        [Required]
        public string fName { get; set; }

        [DisplayName("�H�c")]
        [Required]
        [EmailAddress]
        public string fEmail { get; set; }
    }
}
