
B b = new B();
Console.WriteLine(b.Hi());
//con la sobreescritura se busca el poder modificar y ampliar los methodos de un padra para sus hijos
//agregando la palabra reservada "virtual " a la clase padre
//y "override " a la clase hija


//private : el methodo o atributo solo puede utilizarse en la misma clase
//protected : el methodo o atributo puede ser utilizado en la misma clase y dentro de las clases hijas
//public : el methodo o atributo puede ser utilizado en cualquier lugar


Sale sale = new Sale(10);
sale.Add(2);
sale.Add(3);
Console.WriteLine(sale.GetTotal());

SaleWithtax saleWitTax = new SaleWithtax(10, 1.21m);
saleWitTax.Add(2);
saleWitTax.Add(3);
Console.WriteLine(saleWitTax.GetTotal());

public class A
{
    public virtual string Hi()
    {
        return "Hola soy A";
    }
}

public class B : A
{
    public override string Hi()
    {
        //la palabra reservada "base" es utilizada en Herencia para hacer referencia al padre
        return base.Hi() + " Hola soy B";
    }
}

public class Sale
{
    private decimal[] _amounts;
    private int _n;//cant de elementos
    private int _end;//posisicon final

    public Sale(int n)
    {
        _amounts = new decimal[n];
        _n = n;
        _end = 0;
    }

    public void Add(decimal amount)
    {
        if (_end < _n)
        {
            _amounts[_end] = amount;
            _end++;
        }
    }

    public virtual decimal GetTotal()
    {
        decimal result = 0;
        int i = 0;

        while (i < _amounts.Length)
        {
            result += _amounts[i];
            i++;
        }
        return result;
    }
}

public class SaleWithtax : Sale
{
    private decimal _tax;
    public SaleWithtax(int n, decimal tax) : base(n)
    {
        _tax = tax;
    }

    public override decimal GetTotal()
    {
        return base.GetTotal() * _tax;
    }


}