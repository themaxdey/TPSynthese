using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPSynthese_MaximeDery_JeanSebastienBeaulne
{
    public class Magasin
    {
        public int noMagasin{ get; set;}
        public string nomMagasin { get; set; }
        public string ville { get; set; }
        


        public Magasin(int noMagasin, string nomMagasin, string ville)
        {
            this.noMagasin = noMagasin;
            this.nomMagasin = nomMagasin;
            this.ville = ville;
        }
    }
   
}
