﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_3A2.DTO
{
    internal class DTO_Tecnico
    {
        private string id, espec_id;
        private string nome, email, senha;

        public string Id { get => id; set => id = value; }
        public string Espec_id { get => espec_id; set => espec_id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
