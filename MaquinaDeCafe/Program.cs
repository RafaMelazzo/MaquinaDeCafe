internal class Program
{
    private static void Main(string[] args)
    {
        var maquinaDeCafe = new MaquinaDeCafe();
        maquinaDeCafe.Ligar();
        maquinaDeCafe.AdicionarGrao(new Grao());
        maquinaDeCafe.AdicionarAgua(1000);

        Cafe cafe = maquinaDeCafe.FazerCafe();
        Console.WriteLine(cafe);

        maquinaDeCafe.Desligar();
    }
}