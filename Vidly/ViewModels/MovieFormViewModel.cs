using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Gênero")]
        public byte? GenreId { get; set; }

        [Required]
        [Display(Name = "Data de Lançamento")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Quantidade em Estoque")]
        [Range(1, 30)]
        public byte? NumberInStock { get; set; }

        public IEnumerable<Genre> Genres { get; set; }


        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            GenreId = movie.GenreId;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
        }

        public string Title
        {
            get
            {
                return Id != 0 ? "Editar Filme" : "Novo Filme";
            }
        }
    }
}