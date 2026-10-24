



using System.Numerics;

float n1=0, n2=0, op=0, resultado=0, resUsuario = 0;
int conterrores = 0, contadoraaciertos = 0, puntos = 0;
char operador=' ';
int limite = 11;
Boolean jugador= false;
int[, ] matrix = new int[2,3];
do 
{
    
    n1 = Random.Shared.Next(1, limite);
    n2 = Random.Shared.Next(1, limite);
    op = Random.Shared.Next(1, 5);
    switch (op)
    {

        case 1:
            operador = '+';
            resultado = n1 + n2;
            break;
        case 2:
            operador = '-';
            resultado = n1 - n2;
            break;
        case 3:
            operador = '*';
            resultado = n1 * n2;
            break;
        case 4:
            operador = '/';
            resultado = n1 / n2;
            break;

    }

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"{n1} {operador} {n2} = ?");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("ingrese el resultado: ");
    Console.ForegroundColor = ConsoleColor.Green;
    float.TryParse(Console.ReadLine(), out resUsuario);
    
    if (resUsuario == resultado)
    {
        if (jugador == false)
        {
           matrix[0, 0] = (int)n1;
           matrix[0, 1] = (int)n2;
           matrix[0, 2] = (int)resultado;

           jugador = true;


        }
        else
        {
            matrix[1, 0] = (int)n1;
            matrix[1, 1] = (int)n2;
            matrix[1, 2] = (int)resultado;
            jugador = false;
        }
        contadoraaciertos++;
        puntos += 5;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("¡Correcto!");
        
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrecto, la respuesta correcta es: " + resultado);
        conterrores++;
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Aciertos: {contadoraaciertos} | Errores: {conterrores} | Puntos obtenidos: {puntos}");
    Console.WriteLine("--------------------------------------------------");
    if (contadoraaciertos == 3)
        limite = 101;

    


} while (conterrores < 3) ;
Console.WriteLine("Juego terminado, tuviste 3 errores.");