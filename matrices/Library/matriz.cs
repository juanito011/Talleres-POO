namespace Shared
{
    public class Matriz
    {
        private readonly int[,] _datos;
        public int Filas { get; }
        public int Columnas { get; }

        public Matriz(int filas, int columnas)
        {
            if (filas <= 0 || columnas <= 0)
                throw new ArgumentException("Las dimensiones deben ser mayores que 0.");

            Filas = filas;
            Columnas = columnas;
            _datos = new int[filas, columnas];
        }

        public int this[int fila, int columna]
        {
            get => _datos[fila, columna];
            set => _datos[fila, columna] = value;
        }

        // Llena la matriz A con la fórmula: A[i,j] = (i + 1) * j
        public void LlenarComoA()
        {
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    _datos[i, j] = (i + 1) * j;
                }
            }
        }

        // Llena la matriz B con la fórmula: B[i,j] = (j + 1) * i
        public void LlenarComoB()
        {
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    _datos[i, j] = (j + 1) * i;
                }
            }
        }

        // Multiplicación de matrices
        public static Matriz Multiplicar(Matriz a, Matriz b)
        {
            if (a.Columnas != b.Filas)
                throw new InvalidOperationException("No se pueden multiplicar: el número de columnas de A debe ser igual al número de filas de B.");

            Matriz resultado = new Matriz(a.Filas, b.Columnas);

            for (int i = 0; i < a.Filas; i++)
            {
                for (int j = 0; j < b.Columnas; j++)
                {
                    int suma = 0;
                    for (int k = 0; k < a.Columnas; k++)
                    {
                        suma += a[i, k] * b[k, j];
                    }
                    resultado[i, j] = suma;
                }
            }

            return resultado;
        }

        public void Mostrar(string nombre)
        {
            Console.WriteLine($"*** {nombre} ***");
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    Console.Write(_datos[i, j]);
                    if (j < Columnas - 1)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
