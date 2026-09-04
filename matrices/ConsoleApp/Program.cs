using Shared;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Ingrese el valor de m: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de p: ");
            int p = int.Parse(Console.ReadLine());

            // Crear matriz A (m x n) y llenarla
            Matriz A = new Matriz(m, n);
            A.LlenarComoA();

            // Crear matriz B (n x p) y llenarla
            Matriz B = new Matriz(n, p);
            B.LlenarComoB();

            // Multiplicar A × B
            Matriz C = Matriz.Multiplicar(A, B);

            // Mostrar resultados
            A.Mostrar("A");
            B.Mostrar("B");
            C.Mostrar("C");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}