using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo TÍTULO é obrigatório")]
        public string Titulo { get; set; }
       
        [Required(ErrorMessage = "O campo DIRETOR é obrigatório")]
        public string Diretor { get; set; }
       
        [StringLength(30, ErrorMessage = "O gênero NÃO deve passar de 30 caracteres")]
        public string Genero { get; set; }
      
        [Range(1, 200, ErrorMessage = "A duração do deve ter no MÍNIMO 1 e no MÁXIMO 200 minutos")]
        public int Duracao { get; set; }
       
    }
}
