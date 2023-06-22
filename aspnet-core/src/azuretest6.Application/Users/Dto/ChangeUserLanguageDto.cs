using System.ComponentModel.DataAnnotations;

namespace azuretest6.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}