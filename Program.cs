using System;
using Modelos;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Configuração da Reserva:");
        
        Console.Write("Data mínima (dd/MM/yyyy): ");
        DateTime dataMinima = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Console.Write("Data máxima (dd/MM/yyyy): ");
        DateTime dataMaxima = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Console.Write("Hora mínima (HH:mm): ");
        TimeSpan horaMinima = TimeSpan.ParseExact(Console.ReadLine(), "hh\\:mm", CultureInfo.InvariantCulture);

        Console.Write("Hora máxima (HH:mm): ");
        TimeSpan horaMaxima = TimeSpan.ParseExact(Console.ReadLine(), "hh\\:mm", CultureInfo.InvariantCulture);

        ConfiguracaoReserva configuracao;
        try
        {
            configuracao = new ConfiguracaoReserva(dataMinima, dataMaxima, horaMinima, horaMaxima);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro na configuração: {ex.Message}");
            return;
        }

        Console.WriteLine("\nCadastro da Reserva:");

        Reserva reserva = new Reserva(configuracao);

        Console.Write("Data da reserva (dd/MM/yyyy): ");
        reserva.RegistrarData(DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture));

        Console.Write("Hora da reserva (HH:mm): ");
        reserva.RegistrarHora(TimeSpan.ParseExact(Console.ReadLine(), "hh\\:mm", CultureInfo.InvariantCulture));

        Console.Write("Descrição da sala: ");
        reserva.DescricaoDaSala = Console.ReadLine();

        Console.Write("Capacidade da sala: ");
        reserva.RegistrarCapacidade(int.Parse(Console.ReadLine()));

        var erros = reserva.ValidarReserva();
        if (erros.Count > 0)
        {
            Console.WriteLine("\nErros encontrados:");
            foreach (var erro in erros)
                Console.WriteLine($"- {erro}");
        }
        else
        {
            Console.WriteLine("\nReserva registrada com sucesso:");
            Console.WriteLine(reserva);
        }
    }
}
