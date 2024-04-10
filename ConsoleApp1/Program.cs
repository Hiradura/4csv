using ClassLibrary.Data;
using ClassLibrary.Models;

namespace alapDolgok
{
    public class Program
    {
        static void Kiir(IEnumerable<object> szemelyek)
        {
            foreach (var item in szemelyek)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ValamiContext db = new ValamiContext();

            if (!db.Nyilvantartas.Any())
            {
                var sorok = File.ReadAllLines(@"C:\Users\Diak\dev\oo2\doga\4.csv").Skip(1);
                foreach (var line in sorok)
                {
                    db.Nyilvantartas.Add(new Nyilvantartas(line));
                }
                db.SaveChanges();
            }
            Kiir(db.Nyilvantartas);
        }
    }
}