Console.WriteLine("Escribe un numero por favor:");

double a = double.Parse(Console.ReadLine());



double valorAbsoluto = Math.Abs(a);
double potencia = Math.Pow(valorAbsoluto,3); 
double raizCuadrada = Math.Sqrt(valorAbsoluto);


double seno = Math.Sin(Math.PI * valorAbsoluto /180);
double coseno=Math.Cos(Math.PI * valorAbsoluto/180);
double maximo=Math.Max(valorAbsoluto,50);
double minimo=Math.Min(valorAbsoluto,50);
double parteEntera= Math.Truncate(18.9323);
double redondeo =Math.Round(18.98);




Console.WriteLine("NUMERO: " + a + System.Environment.NewLine + "El valor absoluto es: " + valorAbsoluto + System.Environment.NewLine + "La potencia es " + potencia
    + System.Environment.NewLine + "La raiz cuadrada es: " + raizCuadrada + System.Environment.NewLine + "El seno es: " + seno + System.Environment.NewLine + 
    "El coseno es: " + coseno  + System.Environment.NewLine + "El maximo es: " + maximo +System.Environment.NewLine + "El minimo es: " + minimo 
    +System.Environment.NewLine + "La parte entera es: " + parteEntera  +System.Environment.NewLine + "El redondeo es: " + redondeo);

Console.WriteLine(System.Environment.NewLine +"El ejemplo del ejercicio en el .PDF da como resultado un seno y coseno expresado en grados y el math.sin lo expresa en radianes , 2 horas mas tarde lo he conseguido convertir, vaya tela ");









