using System.ComponentModel.DataAnnotations;

namespace QuanLyBanHang.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}