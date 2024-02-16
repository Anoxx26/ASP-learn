using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_learn.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string? Title { get; set; }
        [Display(Name = "Дата выхода")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set;}
        [Display(Name = "Жанр")]
        public string? Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]

        [Display(Name = "Цена")]
        public decimal Price { get; set; }
    }
}
