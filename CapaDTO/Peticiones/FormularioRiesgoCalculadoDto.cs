using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO.Peticiones
{
    public class FormularioRiesgoCalculadoDto
    {
        public int Id { get; set; }
        public int IdFormulario { get; set; }
        public int ValorPersona { get; set; }
        public int ValorPaisCorrupcion { get; set; }
        public int ValorPaisGAFI { get; set; }
        public int ValorPEP { get; set; }
        public int ValorCotizaBolsa { get; set; }
        public int ValorTamano { get; set; }
        public int ValorOperacionesEfectivo { get; set; }
        public int ValorActivosVirtuales { get; set; }
        public int TotalRiesgo { get; set; }
        public string NivelRiesgoFinal { get; set; }
        public DateTime FechaCalculo { get; set; }
    }
}
