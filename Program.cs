int contador = 0;
int elefantes;

Console.Clear();
Console.Write("Quantos elefantes? ");
elefantes = Convert.ToInt32(Console.ReadLine());
try
{
    if (elefantes < 3) // Verifica se tem 2 elefantes ou menos
    {
        throw new Exception("São necessários mais do que 2 elefantes.");
    }
    else
    {
        if (elefantes % 2 != 0) // Verifica se é impar
        {
            throw new Exception("O número de elefantes deve ser par.");
        }
        else // Se chegou aqui, temos um número par de elefantes maior que 2
        {
            // Adicionar elefantes
        }
    }
}
catch(Exception e)
{
    LogicaElefantes.ExibeMensagemErro(e.Message);
}
finally
{
    Console.ResetColor();
}