namespace Ex01;

public class Circulo
{
    // atributo
    public double raio;

    // atributo calculado
    public double diametro => raio * 2;
    public double circunferencia => 2 * Math.PI * raio;
    public double area => Math.PI * Math.Pow(raio, 2);

    // método
    public override string ToString()
    {
        return $"circulo = {raio}:\ndiametro = {diametro}\ncircuferência = {circunferencia}\narea = {area}";
    }

}
