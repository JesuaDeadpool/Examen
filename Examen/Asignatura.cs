using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Asignatura : Alumno, IAsignatura 
    {
        public int N1 { get; set; } 
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set;}

        public double CalcularNotaFinal()
        {
            throw new NotImplementedException();
        }

        public double CalcularNotaFinal(double nota1, double nota2, double nota3)
        {
            throw new NotImplementedException();
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if(notaFinal >= 0 && notaFinal <= 59)
            {
                return "Repobrado"; 

            }else if(notaFinal >= 60 && notaFinal <= 79)
            {
                return "Bueno";
            }else if(notaFinal >= 80 && notaFinal <= 89)
            {
                return "Muy Bueno";
            }else if (notaFinal >= 90 && notaFinal <= 100)
            {
                return "Sobresaliente"; 
            }
            else
            {
                return "";
            }

          
        }
    }
}
