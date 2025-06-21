

using SimpleBookCatalog.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SimpleBookCatalog.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Por favor, registre um titulo")]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Por favor, registre o nome do autor")]
        [StringLength(100)]
        public string Author { get; set; } = string.Empty;
        public DateTime? PublicationDate { get; set; }

        [EnumDataType(typeof(Category), ErrorMessage ="Por favor, selecione uma categoria")]
        public Category Category { get; set; }
        

    }
}
