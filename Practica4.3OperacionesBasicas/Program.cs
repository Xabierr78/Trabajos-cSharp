using System;

Console.WriteLine("Escribe el primer numero por favor:");

int a = int.Parse(Console.ReadLine());

Console.WriteLine("Escribe el segundo numero por favor:");
int b = int.Parse(Console.ReadLine());

int suma = a + b;
int resta = a - b;
int multiplicacion = a * b;
int division = a / b; 
int residuo = a% b;



Console.WriteLine("PRIMER NUMERO: " + a + System.Environment.NewLine + "SEGUNDO NUMERO: " + b + System.Environment.NewLine + "La suma es: " + suma + System.Environment.NewLine + "La resta es: " + resta + System.Environment.NewLine + "La multiplicacion es: " + multiplicacion
    + System.Environment.NewLine + "La division es: " + division + System.Environment.NewLine + "La division es: " + division + System.Environment.NewLine + "El residuo es: " + residuo); 


