using Matematik;

class LineærFunktion : ILineærFunktion
{
    public double A { get; set; }
    public double B { get; set; }

    public LineærFunktion(double a, double b)
    {
        A = a;
        B = b;
    }

    public double Funktionsværdi(double x)
    {
        return A * x + B;
    }

    public double BestemX(double y)
    {
        return (y - B) / A;
    }

    public bool ErDenSammeSom(ILineærFunktion lineærFunktion)
    {
        throw new System.NotImplementedException();
    }

    public void ForskriftUdFraToPunkter(IPunkt2D punkt1, IPunkt2D punkt2)
    {
        throw new System.NotImplementedException();
    }


    public bool SkærDeHinanden(ILineærFunktion lineærFunktion)
    {
        throw new System.NotImplementedException();
    }

    public Punkt2D Skæring(ILineærFunktion lineærFunktion)
    {
        throw new System.NotImplementedException();
    }
}