using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2.Clases.EJ3
{
    internal class Inventario
    {
        [JsonPropertyName("productos")]
        public List<Producto> Productos { get; set; }
    }
}
