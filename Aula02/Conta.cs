namespace Aula02;

public class Conta
{
    // atributos
    public int numero;
    public string? titular;
    private double saldo;
    public bool ativa;

    // métodos
    // Método para depositar dinheiro na conta
    public void Depositar(double valor)
    {
        // saldo += valor; // Exemplo de atualização do saldo após o depósito
        saldo = saldo + valor; // Exemplo de atualização do saldo após o depósito
    }

    // Método para sacar dinheiro da conta
    public void Sacar(double valor)
    {
        // Lógica para sacar dinheiro
        saldo = saldo - valor; // Exemplo de atualização do saldo após o saque
    }

    // ToString sobrescrito para exibir informações da conta
    public override string ToString()
    {
        return $"Número: {numero}, Titular: {titular}, Saldo: {saldo}";
    }
}
