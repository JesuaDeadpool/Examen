using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public interface IAsignatura
    {

        public double CalcularNotaFinal();
        public double CalcularNotaFinal(double nota1, double nota2, double nota3);

        public string MensajeNotaFinal(double notaFinal);

        public void Imprimir(); 


    }
}
