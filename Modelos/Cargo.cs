using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Ponto.Modelos
{
    internal class Cargo
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Descricao { get; set; }
        public decimal CargaHoraria { get; set; }   
    }
}
