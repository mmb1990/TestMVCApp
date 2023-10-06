using System;
using System.ComponentModel.DataAnnotations;

namespace TestMVCApp.WebApp.Models
{
    public class UserMST
    {
        [Display(Name = "User Name : <br>(This is the user name field)")]
        [Required(ErrorMessage = "Please enter User Name.")]
        public string email { get; set; }

        [Display(Name = "User Password : <br>(This is password field where user can enter the password)")]
        [Required(ErrorMessage = "Please enter User Password.")]
        public string userpassword { get; set; }
    }
}