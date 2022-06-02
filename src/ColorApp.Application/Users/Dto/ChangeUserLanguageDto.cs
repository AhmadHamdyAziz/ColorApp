using System.ComponentModel.DataAnnotations;

namespace ColorApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}