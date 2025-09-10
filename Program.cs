//Programa para operadores de comparación

int valor1, valor2;
Console.WriteLine("Ingrese dos valores para compararlos:");
valor1 = Convert.ToInt32(Console.ReadLine());
valor2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Valores: {valor1}, {valor2}");

bool resultado1 = valor1 == valor2;
Console.WriteLine("El resultado de valor1 == valor2 es: " + resultado1);

bool resultado2 = valor1 != valor2;
Console.WriteLine("El resultado de valor1 != valor2 es: " + resultado2);

bool resultado3 = valor1 > valor2;
Console.WriteLine("El resultado de valor1 > valor2 es: " + resultado3);

bool resultado4 = valor1 < valor2;
Console.WriteLine("El resultado de valor1 < valor2 es: " + resultado4);

bool resultado5 = valor1 >= valor2;
Console.WriteLine("El resultado de valor1 >= valor2 es: " + resultado5);

bool resultado6 = valor1 <= valor2;
Console.WriteLine("El resultado de valor1 <= valor2 es: " + resultado6);



//Programa de tarjeta de presentación
Console.WriteLine("Luis Vásquez ID");
int altura = 160;
int edad = 20;
String nombre = "Luis Mario Vásquez Dominguez";
String informacion = "Nació en Penonomé, es estudiante de Gestión y Desarrollo de Software";
var hobby = "Prácticar programación";
var usuario = "luis13"; // Usuario para iniciar sesión
var contrasena = "1365"; // Contraseña para iniciar sesión

// Mostrar la tarjeta de presentación
String tarjeta = $"""
    Nombre: {nombre}
    Edad: {edad} años
    Altura: {altura} cm
    Información adicional: {informacion}
    Hobby: {hobby}
    Usuario: {usuario}
    Contrasena: {contrasena}
    """;

// Imprimir la tarjeta de presentación
Console.WriteLine(tarjeta);


// Algunos datos 

// Operadores de comparación
/*
== igual a
!= diferente de
> mayor que
< menor que
>= mayor o igual que
<= menor o igual que
*/