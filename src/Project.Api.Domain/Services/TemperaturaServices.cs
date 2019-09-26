using Project.Api.Domain.Entities;
using System;

namespace Project.Api.Domain.Services
{
    public class TemperaturaServices
    {
        public Temperatura GetConversaoFahrenheit(double temperatura)
        {
            Temperatura dados = new Temperatura();
            dados.Fahrenheit = temperatura;
            dados.Celsius = Math.Round((temperatura - 32.0) / 1.8, 2);
            dados.Kelvin = dados.Celsius + 273.15;

            return dados;
        }


    }
}
