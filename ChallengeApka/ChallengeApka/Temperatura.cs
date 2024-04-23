using System.Diagnostics;

namespace ChallengeApka
{
    public class Temperatura : TemperaturaBase
    {
        private const string fileName = "Temperature.txt";

        public Temperatura()
        {
            File.WriteAllText(fileName, string.Empty);
        }
        public override void AddTemp(float temp)
        {
            using(var writer = File.AppendText(fileName)) 
            {
                writer.WriteLine(temp);
            }
            if(temp > 20) 
            {
                Console.WriteLine("Jest ciepło, ubierz się na lato");
            }
            else if(temp <0)
            {
                Console.WriteLine("Jest bardzo zimno, ubierz się ciepło");
            }
        }
        public override void AddTemp(string temp)
        {
            if(float.TryParse(temp, out float result))
            {
                AddTemp(result);
            }
            else 
            {
                Console.WriteLine("String is not float");
            }
        }
        public override void AddTemp(double temp)
        {
            var valueinfloat = (float)temp;
            AddTemp(valueinfloat);
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadTemperaturesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }
        private List<float> ReadTemperaturesFromFile()
        {
            var temps = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        temps.Add(number);
                        line = reader.ReadLine();
                    }
                }

            }
            return temps;
        }
        private Statistics CountStatistics(List<float> temps)
        {
            var statistics = new Statistics();
            foreach (var temp in temps)
            {
                statistics.AddTemp(temp);
            }

            return statistics;
        }
        


    }
}
