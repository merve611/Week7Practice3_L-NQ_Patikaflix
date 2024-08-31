using System.Threading.Channels;
using Week7Practice3_LİNQ_Patikaflix;

internal class Program
{
    public static void Main(string[] args)
    {
        List<Series> series = new List<Series>();

        //kullanıcı konsoldan h girene kadar döngü devam eder
        while (true)
        {
            Series series1 = new Series();
            Console.Write("Dizi ismini giriniz : ");
            series1.Name = Console.ReadLine();
            Console.Write("Yapım yılını giriniz : ");
            series1.YearOfPublication = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dizi türünü giriniz : ");
            series1.Type = Console.ReadLine();
            Console.Write("Yayınlamaya başlama tarihini giriniz : ");
            series1.YearOfPublication = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dizinin yönetmenini giriniz : ");
            series1.Director = Console.ReadLine();
            Console.Write("Yayınlandığı ilk plaformu giriniz : ");
            series1.FirstplatformPublished = Console.ReadLine();

            series.Add(series1);

            Console.WriteLine("Başka bir dizi daha tanımlamak istiyor musunuz ? (e/h)");
            char choice = Convert.ToChar(Console.ReadLine());

            if (choice == 'h')
                break;
        }

        //Yeni liste oluşturularak istenen propertyler alındı
        var newList = series.Select(x => new ComedySeries
        {
            Name = x.Name,
            Type = x.Type,
            Director = x.Director,

        }).ToList();

        //oluşturulan yeni liste üzerinden ilk olarak sizi isimlerine göre sonra yönetmen isimlerine göre sıralamalar yapıldı
        var newListOrder = newList.OrderBy(x => x.Name).ThenBy(x => x.Director);

        foreach (var item in newListOrder)
        {
            Console.WriteLine(item.Name + "--" + item.Director + "--" + item.Type);
        }




    }
}