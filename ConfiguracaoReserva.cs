using System;

namespace Modelos
{
    public class ConfiguracaoReserva
    {
        public DateTime DataMinima { get; private set; }
        public DateTime DataMaxima { get; private set; }
        public TimeSpan HoraMinima { get; private set; }
        public TimeSpan HoraMaxima { get; private set; }

        public ConfiguracaoReserva(DateTime dataMinima, DateTime dataMaxima, TimeSpan horaMinima, TimeSpan horaMaxima)
        {
            if (dataMinima > dataMaxima)
                throw new ArgumentException("A data mínima não pode ser maior que a data máxima.");
            if (horaMinima > horaMaxima)
                throw new ArgumentException("A hora mínima não pode ser maior que a hora máxima.");

            DataMinima = dataMinima;
            DataMaxima = dataMaxima;
            HoraMinima = horaMinima;
            HoraMaxima = horaMaxima;
        }
    }
}
