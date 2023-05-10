using System.ComponentModel;
using System.Security.Cryptography;

/*Console.WriteLine("El resultado : " ); //impresion de datos
 * var nombre = Console.ReadLine(); // escaneo o captura de datos
Console.WriteLine("su nombre es : " + nombre);*/

/* // 
int number = 0; // inicializacion
string name = " "; // inicializacion

double percentage = 10.23; / decimal / float //Asignaciones de datos a variables
char gender = 'M'; // Asignaciones de datos a variables
bool isVerified = true; // Asignaciones de datos a variables
var dinamico = "cualquiercosa" //Asignaciones de datos a variables
*/

// una linea
/*
  Varias 
     lineas
 */

/* // Relacionales
bool result;
int x = 10 , y = 10 ;
result = (x == y);
Console.WriteLine("Equal to Operator: " + result);
result = (x > y);
Console.WriteLine("Greater than Operator: " + result);
result = (x <= y);
Console.WriteLine("Lesser than or Equal to: " + result);
result = (x != y);
Console.WriteLine("Not Equal to Operator: " + result);
Console.WriteLine("Press Enter Key to Exit..");

Console.WriteLine("Equal to Operator: " + result);
*/

/* // Logicos
 * 
 int x = 15, y = 10;
bool a = false, result;
// AND operator
result = (x <= y) && (x > 10);
Console.WriteLine("AND Operator: " + result);

//// OR operator
result = (x >= y) || (x < 5);
Console.WriteLine("OR Operator: " + result);

//NOT operator
result = !a;
Console.WriteLine("NOT Operator: " + result);

Console.WriteLine("Press Enter Key to Exit..");
Console.ReadLine();
  
 */

// Estructuras de Control

// Condicionales o Ternarias o Caso // Loops //  saltos

/*ESTRUCTURA CONDICIONAL DE IF NORMAL*/

/*var edad = 120;
if (edad >= 18)
{
    Console.WriteLine("Eres mayor de edad");
}

else if (edad <= 0 || edad >= 150) 
{
    Console.WriteLine("Porfavor ingresa un parametro correcto");
}

else 
{
    Console.WriteLine("Eres menor de edad");
}*/

/*OPERADOR TERNARIO CONDICIONAL*/

//var edad = 0;
//var resultado = (edad >= 1 && edad <= 150) ? "edad valida" : "edad incorrecta";

//// ? realiza acicon si es true
//// : realiza accion si es false

//Console.WriteLine(resultado);


/*Switch*/

/*var opcion = 1;
var resultado = "";

switch (opcion) {

    case 1 :
        resultado = "Lunes";
    break;
    case 2:
        resultado = "Martes";
        break;
    case 3:
        resultado = "Miercoles";
        break;
    case 4:
        resultado = "Jueves";
        break;
    case 5:
        resultado = "Vienes";
        break;    
    default:
        resultado = "Es Fin de Semana";
        break;
}

Console.WriteLine("El numero es {1} y su resultado es = {0} ", resultado , opcion ); //Impresion por keys
*/



var opcion = "Jupiter";
var resultado = "";

switch (opcion)
{

    case "Lunes":
        resultado = "1";
        break;
    case "Martes":
        resultado = "2";
        break;
    case "Miercoles":
        resultado = "3";
        break;
    case "Jueves":
        resultado = "4";
        break;
    case "Viernes":
        resultado = "5";
        break;
    case "Sabado":
        resultado = "6";
        break;
    case "Domingo":
        resultado = "7";
        break;
    default:
        resultado = "0";
        break;
}

if (resultado == "0") 
{ 
    Console.WriteLine("Digite un dia correcto!");
}

else 
{
    Console.WriteLine($"El dia es {opcion} con numero {resultado}"); // Impresion de datos por interpolacion
}
