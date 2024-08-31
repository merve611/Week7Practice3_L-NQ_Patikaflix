using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7Practice3_LİNQ_Patikaflix
{
    public class Series           //Dizi classı
    {
        public string Name { get; set; }
        public int YearofProduction { get; set; }       //yapım yılı
        public string Type { get; set; }                //dizi türü
        public int YearOfPublication { get; set; }      //Yayınlanmaya başlama yılı
        public string Director { get; set; }            //Yönetmen
        public string FirstplatformPublished { get; set; }     //Yayınlandığı ilk platfrom

    }
}
