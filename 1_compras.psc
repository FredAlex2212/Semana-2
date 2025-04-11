Algoritmo compras
	
	Definir precio, igv, p_total Como Real
	Definir producto Como Caracter
	
	Escribir "Ingresa el nombre del proucto: "
	Leer producto
	
	Escribir 'Ingresa el precio del prodcuto'
	Leer precio
	
	igv <- precio * 0.18
	p_total <- precio + igv
	
	Escribir "Producto: ", producto
	Escribir "Precio: ", precio
	Escribir "IGV: ", igv
	Escribir "Precio total: ", p_total
	
FinAlgoritmo
