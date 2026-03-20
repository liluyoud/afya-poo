namespace Aula08;

public class ContaBancaria
{
    // atributos
    private int numero;
    private string? titular;
    private decimal saldo;
    private decimal limite;
    private bool ativo;

    // construtores
    public ContaBancaria(int numero, string titular)
    {
        this.numero = numero;
        this.titular = titular;
        this.ativo = true;
        // this.limite = 0;
        // this.saldo = 0;
    }

    public ContaBancaria(int numero, string titular, decimal limite)
    {
        this.numero = numero;
        this.titular = titular;
        this.ativo = true;
        this.limite = limite;
        // this.saldo = 0;
    }

    // métodos
    public void Depositar(decimal valor)
    {
        saldo = saldo + valor;
    }

    public void Depositar(double valor)
    {
        saldo = saldo + (decimal)valor; // casting
        // saldo = saldo + Convert.ToDecimal(valor);
    }

    public void Depositar(int valor)
    {
        saldo = saldo + valor;
    }

    public bool Sacar(decimal valor)
    {
        if (SaldoTotal >= valor) {
            saldo = saldo - valor;
            return true;
        }
        else return false;
    }

    public decimal GetSaldo()
    {
        return saldo;
    }

    public decimal SaldoTotal => saldo + limite;
}
