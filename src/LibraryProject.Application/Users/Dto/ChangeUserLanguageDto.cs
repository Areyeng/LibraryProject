using System.ComponentModel.DataAnnotations;

namespace LibraryProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}