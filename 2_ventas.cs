string producto;
double precio, pre_ven, ganancia;

Console.WriteLine("Nombre del Producto: ");
producto = Console.ReadLine();

Console.WriteLine("Precio de compra: ");
precio = Convert.ToDouble(Console.ReadLine());

ganancia = precio * 0.30;
pre_ven = precio + ganancia;

Console.WriteLine("Producto: " + producto);
Console.WriteLine("Precio de compra: " + precio.ToString("F2"));
Console.WriteLine("Precio de venta: " + pre_ven.ToString("F2"));
Console.WriteLine("Ganancia del 30%: " + ganancia.ToString("F2"));