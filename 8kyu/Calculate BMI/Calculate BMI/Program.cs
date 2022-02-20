// See https://aka.ms/new-console-template for more information
double weight = 80;
double height = 1.80;
Console.WriteLine(Bmi(weight, height));

static string Bmi(double weight, double height)
{
    string result = "";
    double BMI = (weight / (Math.Pow(height, 2)));

    if (BMI <= 18.5)
    {
        result = "Underweight";
    }
    else if (BMI <= 25)
    {
        result = "Normal";
    }
    else if (BMI <= 30)
    {
        result = "Overweight";
    }
    else if (BMI > 30)
    {
        result = "Obese";
    }
    return result;
    
}

