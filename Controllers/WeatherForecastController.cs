using Microsoft.AspNetCore.Mvc;
using WebApplication1.Modelos;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost]
        public string mensaje([FromBody] Mensaje mensaje)
        {
            Mensaje algo = new Mensaje(mensaje.Emisor,mensaje.Receptor,mensaje.Cuerpo);
            

           Drive  almacenamiento = new Drive();

            return String.Format($"Emisor: {mensaje.Emisor} Receptor: {mensaje.Receptor} Cuerpo del mensaje: {mensaje.Cuerpo} Archivo: {almacenamiento.Archivo} Url: {almacenamiento.Url}");
        }
    }
}