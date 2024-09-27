using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public record UserForAuthenticationDto
    {
        [Required(ErrorMessage = "Kullanıcı adı gerekli.")]
        public string? UserName { get; init; }
        
        [Required(ErrorMessage = "Şifre gereklidir.")]
        public string? Password { get; init; }
    }
}
