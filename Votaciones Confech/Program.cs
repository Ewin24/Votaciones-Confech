static void Votaciones()
{
    Console.Write("Ingrese la cantidad de universidades que participan en el proceso: ");
    int cantidadUniversidades = int.Parse(Console.ReadLine());

    Dictionary<string, int[]> resultados = new Dictionary<string, int[]>();

    for (int i = 0; i < cantidadUniversidades; i++)
    {
        Console.Write($"Ingrese el nombre de la universidad #{i + 1}: ");
        string nombreUniversidad = Console.ReadLine();

        int[] votos = new int[4]; // Índices 0:Aceptar, 1:Rechazar, 2:Nulo, 3:Blanco

        Console.WriteLine($"Ingrese los votos de los alumnos de {nombreUniversidad} (A:Aceptar, R:Rechazar, N:Nulo, B:Blanco). Termine con 'X':");

        while (true)
        {
            string voto = Console.ReadLine().ToUpper();

            if (voto == "X")
            {
                break;
            }

            switch (voto)
            {
                case "A":
                    votos[0]++;
                    break;
                case "R":
                    votos[1]++;
                    break;
                case "N":
                    votos[2]++;
                    break;
                case "B":
                    votos[3]++;
                    break;
                default:
                    Console.WriteLine("Voto no válido. Intente nuevamente.");
                    break;
            }
        }

        resultados.Add(nombreUniversidad, votos);

        Console.WriteLine($"Total de votos para {nombreUniversidad}: Aceptar={votos[0]}, Rechazar={votos[1]}, Nulo={votos[2]}, Blanco={votos[3]}\n");
    }

    int aceptan = 0, rechazan = 0, empate = 0;

    foreach (var resultado in resultados.Values)
    {
        if (resultado[0] > resultado[1])
        {
            aceptan++;
        }
        else if (resultado[1] > resultado[0])
        {
            rechazan++;
        }
        else
        {
            empate++;
        }
    }

    Console.WriteLine($"Resultado de la votación:\nUniversidades que aceptan: {aceptan} \nUniversidades que Rechazan: {rechazan} \nUniversidades con empate: {empate} ");
}

Votaciones();