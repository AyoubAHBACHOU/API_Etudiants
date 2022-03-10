using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modele.Models
{
    public class Etudiant
    {
        public string nom { get; set; }
        public int id { get; set; }
        public string prenom { get; set; }
        public string image { get; set; }
        public List<Etudiant> amis { get; set; }
        public Etudiant(string n, string m)
        {
            this.nom = n;
            this.prenom = m;
            amis = new List<Etudiant>();
        }
        public Etudiant() { }
        public void addAmis(Etudiant e)
        {
            this.amis.Add(e);
        }
        public string print()
        {
            return this.nom + " " + this.prenom + "\n";
        }
    }
}
