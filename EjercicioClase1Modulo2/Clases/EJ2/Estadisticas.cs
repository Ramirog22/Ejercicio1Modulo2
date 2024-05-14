using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2.Clases.EJ2
{
    internal class Estadisticas
    {
        [JsonPropertyName("estadistica")]
        public List<Equipo> equipos {  get; set; }
    }
}
