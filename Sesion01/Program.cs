using System.Globalization;
using Sesion01;

Console.WriteLine("Sesion 01 en el curso .NET 8 Web Developer - Galaxy Training");
Console.WriteLine(new string('*', 100));

//Console.WriteLine("La siguiente linea, sera un valor vacio (NO NULO)");
//Console.WriteLine(string.Empty);

//Console.WriteLine("Escribe tu nombre");
//string? nombre; // Aqui declaro la variable
//nombre = Console.ReadLine(); // Asigno la variable.

//if (nombre is null)
//    Console.WriteLine("hola terricola"); // Esta condicion nunca se cumple porque ReadLine, nunca devuelve nulo
//else
//    Console.WriteLine("Saludos " + nombre);

//Console.WriteLine("Escribe tu edad:");
//byte edad = byte.Parse(Console.ReadLine()!);

//// Version mas antigua para concatenar valores (2005) .NET Framework 2.0
//Console.WriteLine("Tu edad es " + edad);

//// Version mas elegante de concatenacion
//Console.WriteLine(string.Format("Gracias {0} por decirme tu edad {1}", nombre, edad));

//// Version mas reciente a partir de C# 8.0 (2019 - string interpolation)
//Console.WriteLine($"Que bien! {nombre} espero que tengas un buen dia a tus {edad} años");

//Console.WriteLine("Ingresa tu salario en dolares");
//var salario = float.Parse(Console.ReadLine()!);

//Console.WriteLine(salario);
//Console.WriteLine($"El tipo de dato para la variable 'salario' es de {salario.GetType().Assembly}");
////salario = 15;

//Console.WriteLine($"El valor nuevo de salario es {salario:N4}");
//Console.WriteLine($"Tu salario es de {salario:N2}");

//dynamic otraVariable = "19m";

//Console.WriteLine($"El tipo de dato para la variable 'otraVariable' es de {otraVariable.GetType()}");

//Console.WriteLine("El tipo de dato para la variable 'otraVariable' es de " + otraVariable.GetType().Name);

//otraVariable = 56.8m;

//Console.WriteLine($"Nuevo valor: {otraVariable} y es del tipo {otraVariable.GetType().Name}");

//Console.WriteLine("Escribe tu fecha de nacimiento (YYYY/MM/DD)");

//var fechaNacimiento = DateOnly.Parse(Console.ReadLine()!);

//Console.WriteLine("Formato con Y " + fechaNacimiento.ToString("Y"));
//Console.WriteLine("Formato con D " + fechaNacimiento.ToString("D"));
//Console.WriteLine("Formato con d " + fechaNacimiento.ToString("d"));
//Console.WriteLine("Formato personalizado " + fechaNacimiento.ToString("dd MMM yyyy"));

//Console.WriteLine();

//// Esto cambia la configuracion regional del programa
//System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("es-PE");

//Console.WriteLine("Formatos de fecha y hora");
//var fechaCualquiera = DateTime.Now;

//Console.WriteLine($"Formato fecha larga D => {fechaCualquiera:D}");
//Console.WriteLine($"Formato fecha corta d => {fechaCualquiera:d}");
//Console.WriteLine($"Formato fecha abreviada => {fechaCualquiera:ddd dd MMM 'del' yyyy}");
//Console.WriteLine($"Formato fecha completa => {fechaCualquiera:dddd dd MMMM 'del' yyyy}");
//Console.WriteLine($"Formato fecha y hora completa => {fechaCualquiera:g}");
//Console.WriteLine($"Formato fecha y hora completa 24H => {fechaCualquiera:dd/MM/yyyy HH:mm:ss}");
//Console.WriteLine($"Formato fecha y hora completa AM/PM => {fechaCualquiera:dd/MMM/yyyy hh:mm:ss tt}");

////// Condicionales
////Console.WriteLine("\nIngresa un valor de fecha"); // \n sirve para hacer un salto de linea
//var fecha = DateOnly.Parse(Console.ReadLine()!);

////Console.WriteLine($"El valor de la fecha ingresada es: {fecha}");

////// Validamos la fecha ingresada si es correcta

////Console.WriteLine("\nIngresa un valor de fecha por favor"); // \n sirve para hacer un salto de linea
////if (DateOnly.TryParse(Console.ReadLine(), out fecha))
////{
////    Console.WriteLine($"La fecha ingresada es válida: {fecha:yyyy MMMM dd}");
////}
////else
////{
////    Console.WriteLine("La fecha ingresada, no es válida");
////}



//Console.WriteLine("Ingresa un valor decimal:");

//if (decimal.TryParse(Console.ReadLine(), out decimal valorDecimal))
//{
//    Console.WriteLine($"El valor decimal ingresado es: {valorDecimal:C2}");
//}
//else
//{
//    Console.WriteLine("El valor ingresado no es válido");
//}

var referencia01 = new CultureInfo("en-GB");
var referencia02 = new CultureInfo("en-US");

var valorDecimal = 3456234.98m;

Console.WriteLine($"Valor formato 1: {valorDecimal.ToString("C2", referencia01)}");
Console.WriteLine($"Valor formato 2: {valorDecimal.ToString("C2", referencia02)}");

var fechaActual = DateTime.Now;

Console.WriteLine($"Valor formato fecha 1: {fechaActual.ToString("G", referencia01)}");
Console.WriteLine($"Valor formato fecha´2: {fechaActual.ToString("G", referencia02)}");

var persona01 = new Persona(); // crear instancia de la clase Persona

Console.WriteLine("Persona 01:");
Console.WriteLine("Ingresa tu nombre:");
persona01.Nombre = Console.ReadLine()!;

Console.WriteLine("Ingresa tu apellido:");
persona01.Apellido = Console.ReadLine()!;

Console.WriteLine($"El nombre de la persona es: {persona01.Nombre}, {persona01.Apellido}");
Console.WriteLine($"Demostracion del ToString() => {persona01}");

var variableX = persona01.ToString();
Console.WriteLine(variableX);

Console.WriteLine("Persona 02:");
var persona02 = new Persona(); // crear instancia de la clase Persona

Console.WriteLine("Ingresa tu nombre:");
persona02.Nombre = Console.ReadLine()!;

Console.WriteLine("Ingresa tu apellido:");
persona02.Apellido = Console.ReadLine()!;

persona02.MostrarNombreCompleto();

Console.WriteLine("Fin del programa :-)");