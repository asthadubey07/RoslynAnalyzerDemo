namespace RoslynAnalyzerDemo
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }

    public class Demo
    {
        private string _unusedField; // Unused field (warning)

        public void NullReferenceIssue()
        {
            string? possibleNull = null;
            string nonNullable = possibleNull; // CS8600 Error (null to non-nullable)
            Console.WriteLine(nonNullable);
        }
    }
    }
