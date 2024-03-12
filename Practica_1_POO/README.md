Proyecto de Gestión de Figuras Geométricas:

Descripción:
Desarrolla una aplicación de consola en C# para gestionar diferentes figuras geométricas. Cada figura debe tener al menos una propiedad para calcular su área y un método para mostrar información sobre la figura.

Requisitos:
Crea una clase base llamada FiguraGeometrica con las siguientes propiedades y métodos:
Propiedades: Nombre (nombre de la figura), Color (color de la figura).
Método: MostrarInformacion() que imprime el nombre y el color de la figura.
Implementa dos clases derivadas de FiguraGeometrica:

1.	Circulo: Debe tener una propiedad adicional Radio y calcular el área del círculo.

2.	Rectángulo: Debe tener propiedades Base y Altura y calcular el área del rectángulo.

Defina una interfaz llamada IDibujable con un método Dibujar() que imprimirá un mensaje indicando que la figura se está dibujando.

Implementa la interfaz IDibujable en ambas clases derivadas (Circulo y rectángulo). El método Dibujar() debe imprimir un mensaje específico para cada figura.
