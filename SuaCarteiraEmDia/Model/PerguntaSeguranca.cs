using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuaCarteiraEmDia.Model
{
    public class PerguntaSeguranca
    {
        public int Id { get; set; }


        [Required, MaxLength(100)]
        public required string Pergunta { get; set; }


        [Required, MaxLength(64)]
        public required string Resposta { get; set; }


        [Required]
        public required DateTime DataCricao { get; set; }


        [Required]
        public required int UsuarioID { get; set; }


        public Usuario? Usuario { get; set; }

    }
}
