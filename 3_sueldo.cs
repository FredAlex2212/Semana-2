double sueldo, afp, neto;

Console.WriteLine("¿Cuanto es el sueldo bruto?: ");
sueldo = Convert.ToDouble(Console.ReadLine());

if (sueldo <= 3000)
{
    afp = sueldo * 0.11;
    neto = sueldo - afp;

    Console.WriteLine("Sueldo bruto: " + sueldo.ToString("F2"));
    Console.WriteLine("Descuento AFP (11%): " + afp.ToString("F2"));
    Console.WriteLine("Sueldo neto: " + neto.ToString("F2"));
}

else
{
    afp = sueldo * 0.13;
    neto = sueldo - afp;

    Console.WriteLine("Sueldo bruto: " + sueldo.ToString("F2"));
    Console.WriteLine("Descuento AFP (11%): " + afp.ToString("F2"));
    Console.WriteLine("Sueldo neto: " + neto.ToString("F2"));
}