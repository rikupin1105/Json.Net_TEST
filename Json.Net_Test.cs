using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Json.Net_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //公式サイトから
            string json = @"{
            'Name': 'Bad Boys',
            'ReleaseDate': '1995-4-7T00:00:00',
            'Genres': [
            'Action',
            'Comedy'
            ]
            }";

            Deserialize(json);
            Serialize();
        }

        //デシリアイズ
        static void Deserialize(string json)
        {
            Movie m = JsonConvert.DeserializeObject<Movie>(json);

            Console.WriteLine(m.Name);
            Console.WriteLine(m.ReleaseDate);
            foreach (var item in m.Genres)
            {
                Console.WriteLine(item);
            }
        }
        public class Movie
        {
            public string Name { get; set; }
            public string ReleaseDate { get; set; }
            public string[] Genres { get; set; }
        }


        //シリアライズ
        static void Serialize()
        {
            var product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Sizes = new string[] { "Small" };

            string json = JsonConvert.SerializeObject(product);

            Console.WriteLine(json);
        }
        public class Product
        {
            public string Name { get; set; }
            public DateTime Expiry { get; set; }
            public string[] Sizes { get; set; }
        }
    }
}
