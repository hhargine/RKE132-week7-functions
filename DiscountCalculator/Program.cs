// kui arve summa < 10, siis allahindlus = 1%
// kui summa on 10 >=10 && summa < 20 - 5%
// summa >=20 - 10%

Console.WriteLine("Provide total: ");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculateDiscount(userInput);

Console.WriteLine($"Your discount is: {discount} %");

double newTotal = CalculateNewTotal(userInput, discount);

Console.WriteLine($"Your updated total with {discount}% is: {newTotal}");
static double CalculateDiscount(int total)
{
    if (total < 10)
    {
        return 1;
    }
    else if (total >= 10 && total < 20)  
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculateNewTotal(double total, double discount)
{
    double result = total - (total * discount)/100;
    return result;
}
