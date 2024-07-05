using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuaCarteiraEmDia.Model
{
    public class Movimentacao
    {
        public int Id { get; set; }


        [Required]
        public required char Tipo { get; set; } 


        [Required, MaxLength(100)]
        public required string Descricao { get; set; }


        [Required]
        public required decimal Valor { get; set; }


        [Required]
        public  DateTime DataMovimentacao { get; set; }


        [Required]
        public  DateTime DataCriacao { get; set; }


        [Required]
        public  DateTime DataAlteracao { get; set; }


        [Required]
        public  bool Ativo { get; set; } = true;


        [Required]
        public required int UsuarioID { get; set; }


        [Required]
        public required int CategoriaID { get; set; }


        public Usuario Usuario { get; set; }
        public Categoria Categoria { get; set; }

    }
}
