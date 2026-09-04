using Shared;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Ingrese el tamaño del rombo: ");
            int tamaño = int.Parse(Console.ReadLine());

            Rombo rombo = new Rombo(tamaño);
            rombo.Imprimir();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}