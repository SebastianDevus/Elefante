public class LogicaElefantes
{
    public static void ExibeMensagemErro(string mensagemDeErro)
    {
        Console.Beep();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n{mensagemDeErro}");
    }

    public static void ExibeElefantes(int elefantes)
    {
        int contador = 1;
        int contador2 = 1;

        while (contador <= elefantes)
        {
            if (contador == 1) // Verifica quantidade para concordância verbal
            {
                Console.WriteLine($"{contador++} elefante incomoda muita gente");
            }
            else
            {
                Console.WriteLine($"{contador++} elefantes incomodam muita gente");
            }

            Console.Write($"{contador} elefantes ");

            while (contador2 <= contador)
            {
                Console.Write("incomodam ");
                contador2++;
            }
            contador2 = 1; 

            Console.WriteLine("muito mais\n");
            contador++;
        }
        return;
    }
}