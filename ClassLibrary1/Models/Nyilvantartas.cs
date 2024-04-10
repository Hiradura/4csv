using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    public class Nyilvantartas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Building { get; set; }
        public string ZipCode { get; set; }
        public string Position { get; set; }
        public string Transportation { get; set; }

        public Nyilvantartas()
        {
        }

        public Nyilvantartas(string sor)
        {
            string[] t = sor.Split(';');
            Name = t[0];
            Building = t[1];
            ZipCode = t[2];
            Position = t[3];
            Transportation = t[4];
        }

        public override string? ToString()
        {
             return $"{Name}, neve a(z) {Building} itt dolgozik, ami a, {Position} pozíciója, {ZipCode} írányitó száma, amivel munkába megy: {Transportation}."; 
        }
    }
}