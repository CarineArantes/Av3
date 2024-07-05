﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuaCarteiraEmDia.Model
{
    public class Categoria
    {
        public int Id { get; set; }


        [Required, MaxLength(100)]
        public required string Nome { get; set; }


        [Required, MaxLength(7)]
        public required string Cor { get; set; }


        [Required]
        public  DateTime DataCriacao { get; set; }


        [Required]
        public  DateTime DataAlteracao { get; set; }


        [Required]
        public  bool Ativo { get; set; } = true;



        [Required]
        public required int UsuarioID { get; set; }


        public Usuario? Usuario { get; set; }


    }
}
