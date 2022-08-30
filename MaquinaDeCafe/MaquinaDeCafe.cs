internal class MaquinaDeCafe
{
    const int CAPACIDADE_DE_AGUA = 2000;
    public MaquinaDeCafe()
    {
    }

    public bool Ligada { get; private set; }
    public bool EstaLimpa
    { get
        {
            return BorraDeCafe == null;
        }
    }
    public Grao Grao { get; internal set; }
    public int Agua { get; private set; }
    public BorraDeCafe BorraDeCafe { get; }
    public Po PoDoCafe { get; private set; }

    public void Ligar()
    {
        Ligada = true;
    }
    public void Desligar()
    {
        Ligada = false;
    }
    public void AdicionarGrao(Grao grao)
    {
        Grao = grao;
    }
    public void AdicionarAgua(int mlsDeAgua)
    {
        Agua += mlsDeAgua;
        Agua = Agua > CAPACIDADE_DE_AGUA ? CAPACIDADE_DE_AGUA : Agua;
    }
    internal Cafe FazerCafe()
    {
        MoeGrao();

        if (Ligada == false || Agua < 300 || PoDoCafe == null) return null;

        Agua -= 300;
        return new Cafe();
    }

    private void MoeGrao()
    {
        if (Grao == null) return;
        PoDoCafe = new Po();
        Grao = null;
    }
}