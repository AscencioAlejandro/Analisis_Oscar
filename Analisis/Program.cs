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


/*
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
*/


//string nombre, apellido = " ";
// Concatenacion 

//nombre = "Oscar";
//apellido = "Mejia";

//var nombre_completo = nombre + " " + apellido;

// Impresion concatenada
//Console.WriteLine("El nombre es : " + " " + nombre_completo);

// Impresion por iterpolacion
//Console.WriteLine($"El Nombre es : {nombre_completo}");

//Impresion por posiciones o matrices
//Console.WriteLine("El nombre es : {0} y el apellido es : {1} " , nombre , apellido ); //{0} {1} 

//double precio = 14.45; // Asignacion de datos a una variable
//string name = " "; // Inicializacion

// Operadores

//Varibale estatica
/*int numero_enero = 1000;
int numero_febrero = 200000;

var result1 = (numero_enero > numero_febrero); 

if (numero_enero > numero_febrero)
{
    Console.WriteLine($"La venta mayor fue Enero con un valor : ${numero_enero}");
}
else {
    Console.WriteLine($"La venta mayor fue Febrero con un valor : ${numero_febrero}");
}*/

/*var result2 = (numero_1 < numero_2); //True
Console.WriteLine(result2);

var result3 = (numero_1 <= numero_2); //True
Console.WriteLine(result3);

var result4 = (numero_1 >= numero_2); //False
Console.WriteLine(result4);*/
/*
string numero_cuenta = "";

Console.WriteLine("Porfavor ingrese su numero de cuenta :");
numero_cuenta = Console.ReadLine();

if (numero_cuenta == "ABC123456789")
{

    Console.WriteLine("Exito! ");
}
else {

    Console.WriteLine("Erroneo");

}*/
/*
string contraseña = "";
string username = "";

Console.WriteLine("Porfavor ingresa tu contraseña");
contraseña = Console.ReadLine();
Console.WriteLine("Porfavor ingresa tu username");
username = Console.ReadLine();

if (contraseña == "1234" && username == "admin") // Operador logico AND
{

    Console.WriteLine("Acceso Concedido");

}

else {

    Console.WriteLine("Acceso Denegado");
}*/
/*
string color = "";
string tipo = "";
int cantidad = 0;

Console.WriteLine("Escribe un color");
color = Console.ReadLine();

switch (color) {

    case "Amarillo":
        tipo = "Conocido";
        cantidad = 10;
        break;

    case "Verde":
        tipo = "Conocido";
        break;

    case "Negro":
        tipo = "Conocido";
        break;

    case "Azul":
        tipo = "Conocido";
        break;

    case "Fucsia":
        tipo = "Poco Conocido";
        break;
    case "Turquesa":
        tipo = "Desconocido";
        break;
}

if (tipo == "Conocido" || tipo == "Poco Conocido") { // Operador logico OR
    Console.WriteLine(cantidad);
    Console.WriteLine("Eres normal");

}
else {
    Console.WriteLine("Eres anormal");
}*/

/*
string nombre_producto = "";
double precio = 0;
bool activo = false;
int stock = 0;

Console.WriteLine("Ingrese el nombre del producto ");
nombre_producto = Console.ReadLine() ;
Console.WriteLine("Ingrese el precio del producto ");
precio = Double.Parse(Console.ReadLine());
Console.WriteLine("Seleccione el status del producto ");
activo = bool.Parse( Console.ReadLine());
Console.WriteLine("Seleccione el stock del producto ");
stock = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("************************RESULTADO************************ ");
Console.WriteLine($"Nombre del producto : {nombre_producto} ");
Console.WriteLine($"Precio del producto :  {precio}");
Console.WriteLine("Status del producto :  " + " " + (activo == true ? "Producto Disponible" : "Producto no Disponible")); //Operador ternario
Console.WriteLine("Stock del producto :  " + " " + (stock > 0 ? "Producto Disponible" : "Producto no Disponible")); //Operador ternario
Console.WriteLine("************************************************ "); */

//Analizar 
// Declarar Variables
/*
double monto_compra = 0; // Cliente compro 
double descuento = 0;
double precio_total = 0;

Console.WriteLine("Escriba su monto de compra");
monto_compra = double.Parse(Console.ReadLine());

if (monto_compra > 500 && monto_compra <= 1000) {
  
    descuento =  0.3;   
    precio_total = monto_compra - (monto_compra * descuento);
}

if (monto_compra > 250 && monto_compra < 500)
{
    descuento = 0.1;
    precio_total = monto_compra - (monto_compra * descuento);
}

if (monto_compra < 250)
{
    descuento = 0.05;
    precio_total = monto_compra - (monto_compra * descuento);
}

Console.WriteLine($"Su monto de compra es ${monto_compra} se le aplico el descuento de {descuento * 100}% ");
Console.WriteLine($"Su monto a pagar es ${precio_total} ");
Console.ReadKey();*/


// For While Foreach Do while


//Inicializador , Condicion , Iterador  ++ ascendente/incrementando -- descendente/decremento

/*int numero = 0;
Console.WriteLine("Escoge un numero a multiplicar");
numero = int.Parse(Console.ReadLine());


for (int n = 1; n <= 10; n ++) {

    Console.WriteLine(numero + " X " + n + " = " + (n*n));
}
*/

/*int n = 0;
while (n < 10) {
    n++;
    Console.WriteLine(numero + " X " + n + " = " + (n * n));
}*/

/*
int opcion = 0;
while (opcion != 1)
{
    Console.WriteLine("menu principal");
    Console.WriteLine("desea salir del sistema ? seleccione opcion 1 sino seleccione opcion 2");
    opcion = int.Parse(Console.ReadLine());
}*/

//Arreglo de string [0,1,2,3,4,5,n..]

/*string[] datos_personales = new string[] {"Alejandro", "Jose", "23" , "San Buenaventura" , "1.87"} ;
Console.WriteLine("El tamaño del arreglo es : " + datos_personales.Length);
Console.WriteLine("El nombre es  : " + datos_personales[0]);

for (int n = 0; n < datos_personales.Length; n++) {

    Console.WriteLine($"El N de posision es :{n} y el valor de esa posicion es : {datos_personales[n]}" );

}

*/

// resultado de tipo string , int , decimal , etc.. o un proceso void()

/*
 tipo_acceso publico privado ...
retorno de salida 
nombre_funcion 
 valor de retorno 
 */

/*
  string conversionnombre(string nombre , string apellido) {

    var nombre_completo = nombre + " " + apellido;
    return nombre_completo.ToUpper() ;
    
    }

Console.WriteLine(conversionnombre("Alejandro","Ascencio"));*/