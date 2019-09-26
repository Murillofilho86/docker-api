using System;
using Microsoft.AspNetCore.Mvc;
using Project.Api.Domain.Services;

namespace Project.Api.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversorTemperaturaController : ControllerBase
    {
        /// <summary>
        /// Transforma uma temperatura em Fahrenheit para o equivalente
        /// nas escalas Celsius e Kelvin.
        /// </summary>
        /// <param name="temperatura">Temperatura em Fahrenheit</param>
        /// <returns>Objeto contendo valores para uma temperatura
        /// nas escalas Fahrenheit, Celsius e Kelvin.</returns>
        [HttpGet("Fahrenheit/{temperatura}")]
        public object GetConversaoFahrenheit(double temperatura)
        {
            var servives = new TemperaturaServices();

            return servives.GetConversaoFahrenheit(temperatura);
        }


        [HttpGet("Celsius/{temperatura}")]
        public object GetConversaoCelsius(double temperatura)
        {
            var servives = new TemperaturaServices();

            return servives.GetConversaoFahrenheit(temperatura);
        }

        [HttpGet("Kelvin/{temperatura}")]
        public object GetConversaoKelvin(double temperatura)
        {
            var servives = new TemperaturaServices();

            return servives.GetConversaoFahrenheit(temperatura);
        }
    }
}