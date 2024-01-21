namespace corewebapi.Entities
{
    public class WeatherForecast
    {
        public int Id { get; set; }
        public string? Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }
    }
}
