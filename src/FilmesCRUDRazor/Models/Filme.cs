using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmesCRUDRazor.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }
        //Alterando os nomes
        [Display(Name = "Titulo")]
        [Required]
        public string Titulo { get; set; }

        [Display(Name = "Data de Lançamento")]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataLancamento { get; set; }

        [Display(Name = "Gênero")]
        [Required]
        public string Genero { get; set; }

        [Display(Name = "Preço")]
        // passando pra real
        [DataType(DataType.Currency)]
        // escolhendo quantas casas decimais
        [Column(TypeName = "decimal(18,2)")]
        public decimal preco { get; set; }
    }
}