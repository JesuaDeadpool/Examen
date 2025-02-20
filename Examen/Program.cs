using Examen;

try
{
    Asignatura asignatura = new Asignatura();
    int nota1, nota2, nota3; 

    Console.WriteLine("Ingrese nombre del alumno: ");
    asignatura.NombreAlumno = Console.ReadLine();
    Console.WriteLine("Ingrese número de cuenta: ");
    asignatura.NumeroCuenta = Console.ReadLine();
    Console.WriteLine("Ingrese correo electronico (example@unitec.edu) : ");
    asignatura.Email = Console.ReadLine();
    Console.WriteLine("Ingrese horario de la clase: ");
    asignatura.Horario = Console.ReadLine();
    Console.WriteLine("Ingrese de la clase : ");
    asignatura.NombreAsignatura = Console.ReadLine();
    Console.WriteLine("Ingrese nombre del docente: ");
    asignatura.NombreDocente = Console.ReadLine();

    Console.WriteLine(); 
    Console.WriteLine("Ingrese nota del primer parcial: ");
    nota1 = Convert.ToInt32(Console.ReadLine()); 

    Console.WriteLine("Ingrese nota del segundo parcial: ");
    nota2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese nota del tercer parcial: ");
    nota3 = Convert.ToInt32(Console.ReadLine());

    if (nota1 > 30 || nota2 > 30)
    {
        Console.WriteLine($"La nota que ingreso del primer parcial o segundo parcial sobrepasa del 30%");
    }
    else if (nota3 > 40)
    {
        Console.WriteLine($"La nota que ingreso {nota3} del primer parcial sobrepasa del 40%");

    }
    else
    {
        asignatura.N1 = nota1;
        asignatura.N2 = nota2;
        asignatura.N3 = nota3;
        asignatura.CalcularNotaFinal(nota1, nota2, nota3);
    
    }


    asignatura.Imprimir();

}
catch(Exception e)
{
    Console.WriteLine(e); 
}