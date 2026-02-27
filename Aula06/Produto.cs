namespace Aula06;
public class Produto
{
    // atributos do produto
    private string? nome;
    private int quantidade;
    private double valor;

    // atributo calculado
    public double valorEstoque => quantidade * valor;

    // comportamento = métodos
    // executa alguma ação: comprar e vender

    // o que acontece quando um produto é criado?
    // método construtor
    public Produto(string nome, double valor)
    {
        this.nome = nome;
        quantidade = 0;
        this.valor = valor;
    } 

    // acontece quando a empresa compra um produto
    public void comprar()
    {
        quantidade++;
    }

    // executa quando a empresa vende um produto
    public void vender()
    {
        if (quantidade > 0)
            quantidade--;
        else
            throw new Exception("Não é possivel vender: Estoque zerado");
    }

    // sobrescrever o ToString()
    public override string ToString()
    {
        return $"{nome}: {quantidade} unidades por R$ {valor:N2}";
    }
}
