namespace Algoritmo
{
    class Program
    {
        static void Main(String[] args)
        {

            Console.WriteLine("********* TimeConversion24h *********");
            string time = "09:54:12PM";
            Console.WriteLine(TimeConversion24h(time));

            Console.WriteLine("\n********* GradeRounding *********");
            var grades = new List<int> { 73, 67, 38, 33 };
            Console.WriteLine(String.Join(" ", grades));
            Console.WriteLine(String.Join(" ", GradeRounding(grades)));
            Console.ReadLine();
        }

        static string TimeConversion24h(string? value)
        {
            if (string.IsNullOrEmpty(value)) return "no value";

            string periodo = value.Substring(value.Length -2);
            string[] times = value.Substring(0, 8).Split(':');

            int horas = int.Parse(times[0]);

            if (periodo == "AM" && horas == 12)
            {
                horas = 0;
            }
            else if (periodo == "PM" && horas != 12)
            {
                horas = horas + 12;
            }

            return $"{horas:D2}:{times[1]}:{times[2]}";
        }

        static List<int> GradeRounding(List<int> grades)
        {
            for (int i=0; i < grades.Count(); i++) 
            {
                int grade = grades[i];

                if(grade >= 38)
                {
                    int multiple = ((grade / 5) + 1) * 5;

                    if (multiple - grade < 3)
                    {
                        grades[i] = multiple;
                    }
                }
            }

            return grades;
        }
    }
}