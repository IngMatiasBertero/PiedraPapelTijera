Console.WriteLine("Juego de Piedra Papel o Tijera");
bool parar = true;
while (parar)
{
    Console.WriteLine("Listo para jugar");

    var opcion = Opcion();
    var tuOpcion = Char.Parse(opcion);
    Console.WriteLine("Tu opcion fue " + tuOpcion);

    var Oponenteop = opcionOponente(); 

    Console.WriteLine("El oponente eligio " + Oponenteop);

    Ganador(tuOpcion, Oponenteop);

    salir();
}

string Opcion()
{
    Console.WriteLine("Elige entre R, P o S: [R]ock, [P]aper o [S]cissors:");
    var opcion = Console.ReadLine();

    if (opcion?.ToLower() != "r" && opcion?.ToLower() != "p" && opcion?.ToLower() != "s")
    {
        Console.WriteLine("Eliga una de las opciones porfavor R, P o S");
        opcion = Opcion();
    }
    return opcion;
}

char opcionOponente()
{
    char[] opciones = new char[] { 'R', 'P', 'S' };
    Random random = new Random();   
    int randonIndex=random.Next(0,opciones.Length);

    return opciones[randonIndex];
}

void Ganador(char tuOpcion , char Oponenteop)
{
    if (Oponenteop == tuOpcion)
    {
        Console.WriteLine("Empate");
        return;
    }


    switch (tuOpcion)
    {
        case 'R':
        case 'r':
            if (Oponenteop=='S')
            {
                Console.WriteLine("Ganaste");
            }
            else
            {
                Console.WriteLine("Perdiste");
            }
            break;

        case 'P':
        case 'p':
            if (Oponenteop == 'S')
            {
                Console.WriteLine("Perdiste");
            }
            else
            {
                Console.WriteLine("Ganaste");
            }
            break;
            
        case 'S':
        case 's':
            if (Oponenteop == 'P')
            {
                Console.WriteLine("Ganaste");
            }
            else
            {
                Console.WriteLine("Perdiste");
            }
            break;

        default:
            break;

    }



}


void salir()
{
    Console.WriteLine("Quieres seguir jungnado? s/n");
    string c =Console.ReadLine();
    if (c == "s")
    {
        parar = true;
    }
    else
    {
        parar = false;
    }
}    