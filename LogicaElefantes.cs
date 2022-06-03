public class LogicaElefantes
{
    public static void ExibeMensagemErro(string mensagemDeErro)
    {
        Console.Beep();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n{mensagemDeErro}");
    }
}