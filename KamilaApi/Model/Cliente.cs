using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KamilaApi.Model
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        
        public Cliente()
        {
            Random rd = new Random();
            Id = rd.Next(1, 100);

            Nome = $"Teste {Id}";
        }
    }
}
