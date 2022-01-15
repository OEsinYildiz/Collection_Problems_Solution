// See https://aka.ms/new-console-template for more information


using System.Collections;

int lenght = 6;
int[] arr = new int[lenght];
for (int i = 1; i <= lenght; i++)
{
    Console.WriteLine($"{i}. sayıyı giriniz: ");
    try
    {
        int number = Convert.ToInt32(Console.ReadLine());
        arr[i - 1] = number;
    }
    catch (FormatException)
    {
        throw new Exception("Numeric olmayan karakter girilemez.");
    }
    catch (OverflowException)
    {
        throw new Exception("Negatif olmayan sayılar girilemez.");
    }
}

// En Küçük
Array.Sort(arr);
double averageFirst = Print.ToConsoleAverage(arr);

// En Büyük
Array.Reverse(arr);
double averageSecond = Print.ToConsoleAverage(arr);

Print.ToConsoleAverageSum(averageFirst+averageSecond);

static class Calculater
{
    internal static double Average(int[] arr)
    {
        int[] tempArr = FindElement(arr);
        return Convert.ToDouble(tempArr.Sum() / tempArr.Length);
    }

    private static int[] FindElement(int[] arr)
    {
        int[] newArr = new int[3];
        for (int i = 0; i < 3; i++)
        {
            newArr[i] = arr[i];
        }

        return newArr;
    }
}

static class Print
{
    internal static double ToConsoleAverage(int[] arr)
    {
        double result = Calculater.Average(arr);
        Console.WriteLine($"Dizi ortalaması: {result}");
        return result;
    }

    internal static void ToConsoleAverageSum(double sum)
    {
        Console.WriteLine($"Dizi toplamları: {sum}");
    }
}