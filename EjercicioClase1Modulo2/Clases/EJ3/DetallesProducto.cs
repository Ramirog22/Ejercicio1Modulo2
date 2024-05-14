using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2.Clases.EJ3
{
    internal class DetallesProducto
    {
        [JsonPropertyName("peso")]
        public float Peso {  get; set; }

        [JsonPropertyName("dimensiones")]
        public DimensionesProducto Dimensiones {  get; set; }

    }
}
