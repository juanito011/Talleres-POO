namespace Shared
{
    public class Rombo
    {
        private readonly int _tamaño;

        public Rombo(int tamaño)
        {
            if (tamaño < 1 || tamaño % 2 == 0)
                throw new ArgumentException("El tamaño debe ser un número impar mayor que 0.");

            _tamaño = tamaño;
        }

        public void Imprimir()
        {
            int medio = _tamaño / 2;

            for (int i = 0; i < _tamaño; i++)
            {
                int espaciosAntes = Math.Abs(medio - i);

                Console.Write(new string(' ', espaciosAntes));
                Console.Write("#");

                if (i != 0 && i != _tamaño - 1)
                {
                    int espaciosMedio = _tamaño - 2 * espaciosAntes - 2;
                    Console.Write(new string(' ', espaciosMedio));
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}
