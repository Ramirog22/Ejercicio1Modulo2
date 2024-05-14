using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2.Clases.EJ3
{
    internal class Producto
    {
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("precio")]
        public float Precio { get; set; }

        [JsonPropertyName("existencias")]
        public float Existencias { get; set; }

        [JsonPropertyName("descuento_disponible")]
        public bool TieneDescuento { get; set; }

        [JsonPropertyName("etiquetas")]
        public string[] Tags { get; set; }

        [JsonPropertyName("detalles")]
        public DetallesProducto Detalles { get; set; }

    }
}
