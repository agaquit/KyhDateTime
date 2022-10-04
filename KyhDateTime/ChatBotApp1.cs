using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhDateTime
{
    public class ChatBotApp1
    {

        public void Run()
        {

            Console.WriteLine("Välkommen till ChatBob. Skriv NO eller N för att avsluta");
            while (true)
            {


                Console.WriteLine(":");
                var input = Console.ReadLine();
                var answer = GenerateResponse(input);
             
               
                //input = input.ToUpper();
                if (input == "N" || input == "NO") break;
                Console.WriteLine(answer);

            }
            Console.WriteLine("Ha en fortsatt trevlig dag");

        }


        public string GenerateResponse(string input)
        {
            if (input.EndsWith("?")) return "Sure";
            if (input.EndsWith("!")) return "Calm down, I know what I'm doing";
            if (input.Length == 0) return "Fine. Be that way!";
           

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]) == false)
                {
                    return "Whoa, chill out dude";
                }
            }

            return "Whatever";













            //    public void Run()
            //    {
            //        while (true)
            //        {
            //            Console.WriteLine(":");
            //            var input = Console.ReadLine();
            //            var answer = GetRandomAnswer();
            //            Console.WriteLine(answer);
            //        }

            //    }

            //    private string GetRandomAnswer()
            //    {
            //        var random = new Random();
            //        var arrayOfAnswers = new string[]
            //        {
            //            "Jag mår bra",
            //            "Lämna mig ifred",
            //            "vad sa du?",
            //            "Whatever",
            //            "Kanske det",
            //            "Ingen aning",
            //            "Ja vad bra",


            //        };
            //        int index = random.Next(0, arrayOfAnswers.Length);
            //        return arrayOfAnswers[index];


            //    }

        }

        public class ChatBob
        {

            public void Run()
            {
                while (true)
                {


                    Console.WriteLine("Säg något till Bob :)");
                    var input = Console.ReadLine();
                    var answer = GenerateResponse(input);
                    Console.WriteLine(answer);
                    Console.WriteLine("Vill du fortsätta? Skriv NO eller N för att avsluta");
                    input = input.ToUpper();
                    if (input == "N" || input == "NO") break;

                }
                Console.WriteLine("Ha en fortsatt trevlig dag");

            }


            public string GenerateResponse(string input)
            {
                if (input.EndsWith("?")) return "Sure";
                if (input.EndsWith("?!")) return "Calm down, I know what I'm doing";
                if (input.EndsWith("")) return "Fine. Be that way!";
                if (input.EndsWith("")) return "Whoa, chill out";
                return "Whatever";
            }





        }



    }
}