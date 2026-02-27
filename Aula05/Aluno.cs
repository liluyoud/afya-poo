namespace Aula05;

public class Aluno
{
    // características - atributos
    public string? nome;
    public double n1;
    public double n2;

    // atributo calculado: obtido através de outros atributos
    public double media => (n1 + n2) / 2;

    // comportamentos - métodos - (subprogramas)
    public override string ToString()
    {
        return $"O aluno {nome} tem média {media}";
    }
}
