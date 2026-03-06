using System;

namespace Aula07;

public class Produto
{
    // atributos
    public string? descricao;
    public int quantidade;
    public double valor;

    // atributo calculado
    public double valorEstoque => quantidade * valor;

    public void comprar()
    {
        // quantidade += 1;
        // quantidade++;
        quantidade = quantidade + 1;
    }

    public bool vender(int qtdParaVender)
    {
        if (quantidade >= qtdParaVender) {
            quantidade -= qtdParaVender;
            return true;
        } 
        else return false;
    }
}
