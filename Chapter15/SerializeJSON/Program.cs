using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;



namespace SerializeJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            Book book1 = new Book
            {
                title = "Beginning C# and .Net",
                author = "Benjamin Perkins and Jon Reid",
                code = "978-1119796780"
            };
            Book book2 = new Book
            {
                title = "Beginning XML",
                author = "Joe Fawcett",
                code = "978-1119796412"
            };
            Book book3 = new Book
            {
                title = "Professional C# and .Net",
                author = "Christian Nagel",
                code = "978-111979613"
            };

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

            string jsonString1 = JsonSerializer.Serialize(books, typeof(List<Book>));
            File.WriteAllText("Books.json", jsonString1);

            string jsonString2 = File.ReadAllText("Books.json");
            List<Book> books2 = JsonSerializer.Deserialize<List<Book>>(jsonString2);
            foreach (Book b in books2)
            {
                Console.WriteLine("code: {0}  title: {1}  author: {2}  ",
                    b.code, b.title, b.author);
            }

            string jsonString3 = File.ReadAllText("../../../Weather.json");
            Weather weather = JsonSerializer.Deserialize<Weather>(jsonString3);


            Console.WriteLine(nameof(weather.Date) + ": " + weather.Date.ToString());
            Console.WriteLine(nameof(weather.TemperatureCelsius) + ": " + weather.TemperatureCelsius.ToString());
            Console.WriteLine(nameof(weather.Summary) + ": " + weather.Summary.ToString());


            Console.WriteLine("\t" + nameof(weather.Date) + ": " + weather.Date.ToString());
            Console.WriteLine("\t" + nameof(weather.TemperatureCelsius) + ": " + weather.TemperatureCelsius.ToString());
            Console.WriteLine("\t" + nameof(weather.Summary) + ": " + weather.Summary.ToString());

            Console.Write("\t" + nameof(weather.DatesAvailable) + ": ");
            foreach (DateTime datAvail in weather.DatesAvailable)
            {
                if (weather.DatesAvailable.Last() == datAvail)
                    Console.Write(datAvail.ToString());
                else
                    Console.Write(datAvail.ToString() + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("\t" + nameof(weather.TemperatureRanges) + ": ");
            Console.WriteLine("\t{");
            Console.WriteLine("\t\t" + nameof(weather.TemperatureRanges.Cold) + ": ");
            Console.WriteLine("\t\t{");
            Console.WriteLine("\t\t\t" + nameof(weather.TemperatureRanges.Cold.High) + ": " + weather.TemperatureRanges.Cold.High);
            Console.WriteLine("\t\t\t" + nameof(weather.TemperatureRanges.Cold.Low) + ": " + weather.TemperatureRanges.Cold.Low);
            Console.WriteLine("\t\t}");
            Console.WriteLine("\t\t" + nameof(weather.TemperatureRanges.Hot) + ": ");
            Console.WriteLine("\t\t{");
            Console.WriteLine("\t\t\t" + nameof(weather.TemperatureRanges.Hot.High) + ": " + weather.TemperatureRanges.Hot.High);
            Console.WriteLine("\t\t\t" + nameof(weather.TemperatureRanges.Hot.Low) + ": " + weather.TemperatureRanges.Hot.Low);
            Console.WriteLine("\t\t}");
            Console.WriteLine("\t}");

            Console.Write("\t" + nameof(weather.SummaryWords) + ": ");
            foreach (string word in weather.SummaryWords)
            {
                if (weather.SummaryWords.Last() == word)
                    Console.Write(word);
                else
                    Console.Write(word + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("}");
            Console.ReadKey();



            Console.WriteLine(
                @"{
  ""Date"": ""2019-08-01T00:00:00-07:00"",
  ""TemperatureCelsius"": 25,
  ""Summary"": ""Hot"",
  ""DatesAvailable"": [
    ""2019-08-01T00:00:00-07:00"",
    ""2019-08-02T00:00:00-07:00""
  ],
  ""TemperatureRanges"": {
    ""Cold"": {
      ""High"": 20,
      ""Low"": -10
    },
    ""Hot"": {
      ""High"": 60,
      ""Low"": 20
    }
  },
  ""SummaryWords"": [
    ""Cool"",
    ""Windy"",
    ""Humid""
  ]
}"
);
            }


        }
	

	







        public class Weather
        {
            public DateTime Date { get; set; }
            public int TemperatureCelsius { get; set; }
            public string Summary { get; set; }

            public List<DateTime> DatesAvailable { get; set; }

            public TemperatureRanges TemperatureRanges { get; set; }

            public List<string> SummaryWords { get; set; }
        }

        public class TemperatureRanges
        {

            public int Cold { get; set; }
            public int Hot { get; set; }

        }

        public class Ranges
        {
            public int High { get; set; }
            public int Low { get; set; }

        }




    } 