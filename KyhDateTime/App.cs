using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhDateTime
{
    public class App
    {

        public string GetSwedishWeekDayName(DayOfWeek dayOffWeek)
        {
            switch (dayOffWeek)
            {
                case DayOfWeek.Monday:
                    return "Måndag";
                case DayOfWeek.Tuesday:
                    return "Tisdag";
                case DayOfWeek.Wednesday:
                    return "Onsdag";
                case DayOfWeek.Thursday:
                    return "Torsdag";
                case DayOfWeek.Friday:
                    return "Fredag";
                case DayOfWeek.Saturday:
                    return "Lördag";
                default:
                    return "Söndag";



            }

        }


        public void DagCounter()
        {
            Console.WriteLine("Ange ditt födelseår: ");
            var year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ange ditt födelsemånad(1-12): ");
            var month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ange din dag(1-31)=: ");
            var day = Convert.ToInt32(Console.ReadLine());

            var yourBirthDay = new DateTime(year, month, day);

            Console.WriteLine($"Du är född på en {yourBirthDay.DayOfWeek}");
            var nameInSwedish = GetSwedishWeekDayName(yourBirthDay.DayOfWeek);
            Console.WriteLine($"På svenska är det {nameInSwedish}");
            if (yourBirthDay.DayOfWeek == DayOfWeek.Saturday || yourBirthDay.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Ok du är född på en helg tyvärr, alla helgfödda är lata :(");

            }
            var aktuellDag = DateTime.Now;
            var diff = aktuellDag - yourBirthDay;
            Console.WriteLine($"Du är {diff.TotalDays} gammal. Har du använt dem väl?");



        }


        public void Run()
        {
            CalculateDaysToChristmasVacation();

            Invoice();
       
            var aktuellDag = DateTime.Now;
            var SnyggtDatum = aktuellDag.ToString("yyyy-MM-dd");
            Console.WriteLine(aktuellDag);

            DagCounter();

        }

        private void CalculateDaysToChristmasVacation()
        {
            var vacationStarts = new DateTime(2022, 12, 21);
            Console.WriteLine("Ange datum i format 2022-10-01");
            var inmatning = Console.ReadLine();

            var datum = DateTime.ParseExact(inmatning,"yyyy-MM-dd",CultureInfo.CurrentCulture);
           
            var diff = vacationStarts - datum;
            Console.WriteLine($"Håll ut det är {diff.TotalDays} dagar kvar till jullovet");
        }

        public void Invoice()
        {
          var invoiceDate = DateTime.Now;
            Console.WriteLine($"Fakturadag:  {invoiceDate.ToString("yyy-MM-dd")}");
            var dueDate = invoiceDate.AddDays(30);
            if (dueDate.DayOfWeek == DayOfWeek.Saturday)
                dueDate = dueDate.AddDays(-1);
            else if (dueDate.DayOfWeek == DayOfWeek.Sunday)
                dueDate = dueDate.AddDays(1);

            Console.WriteLine($"Förfallodag: {dueDate.ToString("yyyy-MM-dd")}");
        }
    }
}
