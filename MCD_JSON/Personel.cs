﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_JSON
{
    public class Personel
    {
        public Guid ID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Adres { get; set; }
        public string EmailAdres { get; set; }
        public string TelefonNo { get; set; }
    }
}
