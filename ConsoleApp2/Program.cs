using System;

class ComplexNumber
{
    //definuje vlastnosti veřejného přístupu be třídě
    public double Real { get; set; }
    public double Imaginary { get; set; }

    // definuje konstruktor pro complexnumber
    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // matematické operace 
    // metoda na vracejicí novou instanci třídy complexnumber vytvořenou jakožto součet instance this a instance other ktera je předána jako parametr
    public ComplexNumber Add(ComplexNumber other)
    {
        return new ComplexNumber(Real + other.Real, Imaginary + other.Imaginary);
    }

    public ComplexNumber Subtract(ComplexNumber other)
    {
        return new ComplexNumber(Real - other.Real, Imaginary - other.Imaginary);
    }

    public ComplexNumber Multiply(ComplexNumber other)
    {
        return new ComplexNumber(Real * other.Real - Imaginary * other.Imaginary, Real * other.Imaginary + Imaginary * other.Real);
    }

    public ComplexNumber Divide(ComplexNumber other)
    {
        double denominator = Math.Pow(other.Real, 2) + Math.Pow(other.Imaginary, 2);
        return new ComplexNumber((Real * other.Real + Imaginary * other.Imaginary) / denominator, (Imaginary * other.Real - Real * other.Imaginary) / denominator);
    }

    // přepíše ToString a vratí hodnotu pomocí příkazu return(řádek 41)
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

// vypisuje příkazy pro uživatele pomocí console.writeLine
// Program načte vstup z konzole pomocí metody Console.ReadLine
// vstupní řetězec je rozdělen na dvě části pomocí metody Split
class Program

{
    static void Main(string[] args)
    {
        // Vypíše se zpráva do konzole aby uživatel zadal první číslo
        Console.WriteLine("Zadejte první komplexní číslo:");
        Console.Write("Reálná část: ");
        //přečte obě hodnoty a přepíše je na cíšlo typu "double"
        double real1 = Convert.ToDouble(Console.ReadLine());
        //to samé akorát s imaginarními čísly
        Console.Write("Imaginární část: ");
        double imaginary1 = Convert.ToDouble(Console.ReadLine());
        //vytvoří se třída complexnumber
        ComplexNumber complex1 = new ComplexNumber(real1, imaginary1);
        //to samé jako nahore
        Console.WriteLine("Zadejte druhé komplexní číslo:");
        Console.Write("Reálná část: ");
        double real2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Imaginární část: ");
        double imaginary2 = Convert.ToDouble(Console.ReadLine());

        ComplexNumber complex2 = new ComplexNumber(real2, imaginary2);
        //vypočíta se součet dvou zadaných komplexních čísel pomocí ADD
        ComplexNumber sum = complex1.Add(complex2);
        //vypočíta se součet dvou zadaných komplexních čísel pomocí DIFF
        ComplexNumber difference = complex1.Subtract(complex2);
        //vypíše výsledek do konzole
        Console.WriteLine($"Součet: {sum}");
        Console.WriteLine($"Rozdíl: {difference}");
    }
}
