using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagement.Core.Entities
{
    public class Usuario
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public string SOBRENOME { get; set; }
        public string EMAIL { get; set; }
        public DateTime DATA_NASCIMENTO { get; set; }
        public int ESCOLARIDADE { get; set; }
    }
}