using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Ders1.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string BooksName { get; set; }
        [Required]
        public string author { get; set; }//yazar bilgisi
        [Required]
        public int NumberOfPages { get; set; }//sayfa sayısı
        [ValidateNever]
        public int? WriteYear { get; set; }
    }
}
