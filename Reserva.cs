using System;
using System.Collections.Generic;

namespace Modelos
{
    public class Reserva
    {
        public DateTime Data { get; private set; }
        public TimeSpan Hora { get; private set; }
        public string DescricaoDaSala { get; private set; }
        public int Capacidade { get; private set; }
        private ConfiguracaoReserva Configuracao;

        public Reserva(ConfiguracaoReserva configuracao)
        {
            Configuracao = configuracao;
        }

        public void RegistrarData(DateTime data)
        {
            Data = data;
        }

        public void RegistrarHora(TimeSpan hora)
        {
            Hora = hora;
        }

        public void RegistrarCapacidade(int capacidade)
        {
            Capacidade = capacidade;
        }

        public List<string> ValidarReserva()
        {
            List<string> erros = new List<string>();

            if (Data < Configuracao.DataMinima || Data > Configuracao.DataMaxima)
                erros.Add($"A data da reserva deve estar entre {Configuracao.DataMinima:dd/MM/yyyy} e {Configuracao.DataMaxima:dd/MM/yyyy}.");

            if (Hora < Configuracao.HoraMinima || Hora > Configuracao.HoraMaxima)
                erros.Add($"A hora da reserva deve estar entre {Configuracao.HoraMinima:hh\\:mm} e {Configuracao.HoraMaxima:hh\\:mm}.");

            if (Capacidade <= 0 || Capacidade >= 40)
                erros.Add("A capacidade da sala deve ser maior que 0 e menor que 40.");

            if (string.IsNullOrWhiteSpace(DescricaoDaSala))
                erros.Add("A descrição da sala não pode estar vazia.");

            return erros;
        }

        public override string ToString()
        {
            return $"Reserva da sala '{DescricaoDaSala}' para {Capacidade} alunos no dia {Data:dd/MM/yyyy} às {Hora:hh\\:mm}.";
        }
    }
}
