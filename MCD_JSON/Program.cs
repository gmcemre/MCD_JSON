﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MCD_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personel> Personellerim = new List<Personel>();
            for (int i = 0; i < 1000; i++)
            {
                Personel P1 = new Personel();
                P1.ID = Guid.NewGuid();
                P1.Isim = FakeData.NameData.GetFirstName();
                P1.Soyisim = FakeData.NameData.GetSurname();
                P1.EmailAdres = $"{P1.Isim}.{P1.Soyisim}@{FakeData.NetworkData.GetDomain()}";
                P1.TelefonNo = FakeData.PhoneNumberData.GetPhoneNumber();

                Personellerim.Add(P1);

            }

            Console.WriteLine("Bilgileriniz JSON formatında kaydedilecektir.");

            //http: //jsonviewer.stack.hu/
            if (Directory.Exists(@"c:\\JsonIslemlerim\\"))
            {

            }
            else
            {
                Directory.CreateDirectory(@"c:\\JsonIslemlerim\\");
            }
            string JsonPersonellerim = Newtonsoft.Json.JsonConvert.SerializeObject(Personellerim);
            File.WriteAllText("c:\\JsonIslemlerim\\Personellerim.json", JsonPersonellerim);
        }
    }
}
