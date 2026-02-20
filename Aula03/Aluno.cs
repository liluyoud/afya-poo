namespace Aula03;

public class Aluno
{
    // características do aluno
    public string? nome;
    public string? matricula;
    public string? email;
    public double n1;
    public double n2;

    // comportamento do aluno
    public double CalcularMedia()
    {
        double media = (n1 + n2) / 2;
        return media;
    }

    public bool EstaAprovado()
    {
        double media = CalcularMedia();
        if (media >= 7)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
