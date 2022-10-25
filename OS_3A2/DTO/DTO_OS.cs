using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_3A2.DTO
{
    internal class DTO_OS
    {
        private int id, tecnico, usuario;
        private string descricao, status;

        public int Id { get => id; set => id = value; }
        public int Tecnico { get => tecnico; set => tecnico = value; }
        public int Usuario { get => usuario; set => usuario = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Status { get => status; set => status = value; }
    }
}
