﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuaCarteiraEmDia.Model
{
    public class Usuario
    {
        public int Id { get; set; }


        [Required,MaxLength(60)]
        public required string Nome { get; set; }


        [Required,MaxLength(60)]
        public required string UserName { get; set; }


        [Required,MaxLength(64)]
        public required string Senha { get; set; }


        [Required]
        public  DateTime DataCriacao { get; set; }


        [Required]
        public  DateTime DataAlteracao { get; set; }


        [Required]
        public  bool Ativo { get; set; } = true;

    }
}
