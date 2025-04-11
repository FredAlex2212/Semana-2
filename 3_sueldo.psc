Algoritmo sueldo
	
	Definir sueld, afp, neto Como Real
	
	Escribir "¿Cuanto es tu sueldo bruto?: "
	Leer sueld
	
	si sueld <= 3000 Entonces
		afp = sueld * 0.11
		neto = sueld - afp
		
		Escribir "Sueldo bruto: ", sueld
		Escribir "Descuento AFP (11%): ", afp
		Escribir "Sueldo Neto: ", neto
	SiNo
		afp = sueld * 0.13
		neto = sueld - afp
		
		Escribir "Sueldo bruto: ", sueld
		Escribir "Descuento AFP (11%): ", afp
		Escribir "Sueldo Neto: ", neto
	FinSi
	
FinAlgoritmo
