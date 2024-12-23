using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo{
        public int Id { get; set; }
        [Required (ErrorMessage ="Geçerli Bir Ad Giriniz")]
        public string? Name { get; set; }
        [Required (ErrorMessage ="Geçerli Bir Telefon Giriniz")]
        public string? Phone { get; set; }
        [Required (ErrorMessage ="Geçerli Bir E-posta Giriniz")]
        public string? Email { get; set; }
        [Required (ErrorMessage ="Katılım Durumu Seçiniz")]
        public bool? WillAttend { get; set; }
    }
}