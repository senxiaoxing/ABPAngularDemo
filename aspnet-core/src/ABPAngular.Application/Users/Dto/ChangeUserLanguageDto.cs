using System.ComponentModel.DataAnnotations;

namespace ABPAngular.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}