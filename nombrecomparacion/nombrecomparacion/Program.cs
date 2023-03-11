
string palabra;
palabra = "maria";
marque(palabra);
bool esPalindromo = palindromo("anA");

static bool palindromo(String palabra);
{
    int longitud = palabra.Length;
    string pal = "";
    for (int c = longitud - 1; c >= 0; c--)
    {
        pal = pal + palabra[c].ToString().ToUpeer();
    }

    if (palabra.Equals(pal))
    {
        return true;
    }
    else
    {
        return false;
    }
}




//equals para hacer comparaciones con tipo de dato string, se usa equals y no ==




if (esPalindromo)
{
    Console.WriteLine("Es palindromo");
}
else
{
    Console.WriteLine("NEL");
}


static void marque(String palabra)
{
    int longitud = palabra.Length;
    string pal = "";
    for (int c = longitud - 1; c >= 0; c--)
    {
        pal = pal + palabra[c];
        //Console.SetCursorPosition(5+c,10);
        //Console.Write(palabra[c]);
        //Thread.Sleep(100);
    }
    //Console.WriteLine(pal);

    //Console.WriteLine(palabra[2]);
}


//static void saludar (String nomsal)        //Al utilizar el void no me devolvera nada
//{
//    Console.WriteLine($"Un gran saludo a {nomsal}");
//}

//static int calculo_año_nacimiento (int edad)      //al utilizar int si nos devolvera un dato tipo entero, por eso la funcion "return" para que me devuelva la variable
//{
//    int añon = 2023 - edad;
//    return añon;               //La diferencia entre una y otra es que la primera no devuelve valor y la segunda si lo hace, cuando un bloque de codigo no devuelve valor lo llamaremos metodo, y cuando devuelva de cualquier tipo lo llamaremos funcion
//}


//    string nombre;
//    int edad;

//    Console.WriteLine("Cómo te llamas?");
//    nombre = Console.ReadLine();                //Cuando un codigo queda encerrado entre llaves "{ }" estamos segmentando el codigo, lo que esta adentro se queda adentro
//    saludar(nombre);

//Console.WriteLine($"Hola, gusto de saludarte {nombre}");
//Console.WriteLine("Cúantos años tienes?");
//edad=Convert.ToInt32(Console.ReadLine());



//Console.WriteLine($"Bonita edad: {edad} \n naciste en {calculo_año_nacimiento(edad)}");



//EXPLICACION DE STRING Y CHAR

//char letra = 'a';
//string palabra = letra;
