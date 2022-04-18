using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace eRent.Model.Request.Grad
{
    public class GradInsertRequest
    {

        [Required]
        public string Naziv { get; set; }
        [Required]
        public int DrzavaId { get; set; }
    }
}
