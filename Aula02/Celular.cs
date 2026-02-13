using System;

namespace Aula02;

public class Celular
{
    public string? marca;
    public string? modelo;
    public double preco;

    public override string ToString()
    {
        return $"Marca: {marca}, Modelo: {modelo}, Preço: {preco}";
    }
}
