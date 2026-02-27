namespace Aula04;

public class Professor
{
    public string? nome;
    private double salario;
    private string? cpf;
    public string? email;
    public bool ativo;

    // construtor
    public Professor()
    {
        nome = null;
        salario = 0;
        cpf = null;
        email = null;
        ativo = false;
    }

}
