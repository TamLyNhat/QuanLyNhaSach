using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TKHTTT.Models
{
    public class LoginModel1
    {
        [Required]
        public string SoDT { set; get; }
        public string MatKhauNV { set; get; }
        public bool Rememberme { set; get; }

    }
}