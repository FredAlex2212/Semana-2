double precio, igv, p_total;
string producto;

Console.WriteLine("Ingresa el nombre del producto: ");
producto = Console.ReadLine();

Console.WriteLine("Ingresa el precio del producto: ");
precio = Convert.ToDouble(Console.ReadLine());

igv = precio * 0.18;
p_total = precio + igv;

Console.WriteLine("Producto: " + producto);
Console.WriteLine("Precio: " + precio.ToString("F2"));
Console.WriteLine("IGV: " + igv.ToString("F2"));
Console.WriteLine("Precio total: " + p_total.ToString("F2°"));