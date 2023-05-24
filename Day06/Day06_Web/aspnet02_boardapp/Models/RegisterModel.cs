using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace aspnet02_boardapp.Models
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        [DisplayName(Name = "이메일주소")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [DisplayName(Name = "패스워드")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [DisplayName(Name = "패스워드 확인")]
        [Compare("Password", ErrorMessage = "패스워드가 일치하지 않습니다. 다시 입력하세요.")]
        public string ConfirmPassword { get; set; }
    }
}
