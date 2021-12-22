using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MCD_JSONOkuma
{
    class Program
    {
        static void Main(string[] args)
        {

            string JsonOkumaData = File.ReadAllText("c:\\JsonIslemlerim\\Personellerim.json");
            List<Personel> Data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Personel>>(JsonOkumaData);

            for (int i = 0; i < 50; i++)
            {
                //Console.WriteLine(Data[i].ID);
                Console.WriteLine(Data[i]);
                //Console.WriteLine(Data[i].Soyisim);
                //Console.WriteLine(Data[i].Adres);
                //Console.WriteLine(Data[i].EmailAdres);
                //Console.WriteLine(Data[i].TelefonNo);
            }

            Console.ReadLine();
        }
    }
}
