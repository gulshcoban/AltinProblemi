using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
namespace AltınProblemi
{
    public class Altin
    {
        public const ulong AGIRLIK = 5;
        public ulong[] Altinlar { get; set; }
        public ulong IndisBul { get; set; }
        public ulong AltinSayisi { get; set; }
        public ulong KacinciOlcum { get; set; }
        public Altin(ulong altinsayisi)
        {
            this.AltinSayisi = altinsayisi;
            Altinlar = new ulong[altinsayisi];
            for (ulong i = 0; i < altinsayisi; i++)
            {
                Altinlar[i] = AGIRLIK;
            }
            Random rnd = new Random();
            //Random olacak ağırlığın indisinin random olarak belirlenmesi
            this.IndisBul = Convert.ToUInt64(rnd.Next(0, Convert.ToInt32(AltinSayisi)));
            Altinlar[IndisBul] = Convert.ToUInt64(rnd.Next(1, 6));
            //Aynı ağırlık değerinin tekrarlanmaması kontrolü
            if (Altinlar[IndisBul] == AGIRLIK)
                Altinlar[IndisBul] = Convert.ToUInt64(rnd.Next(6, 10));

        }
        private string HataliAltiniBul(ulong[] Altinlar)
        {
            ulong baslangic = 0, bitis = Convert.ToUInt64(Altinlar.Length - 1), orta = baslangic + bitis / 2;
            ulong ayni = AGIRLIK, farkli = 0, indis = 0;
            while (baslangic <= bitis)
            {
                KacinciOlcum++;
                orta = (baslangic + bitis) / 2;
                if (Altinlar[orta] != AGIRLIK)
                {
                    return "Altın Sayısı:" + this.AltinSayisi.ToString() + "\n" +
                   "Altın Numarası:" + (orta + 1).ToString() + "\n" +
                   "Ağırlığı:" + Altinlar[orta].ToString() + "gr" + "\n" +
                   "Tartım Sayısı:" + KacinciOlcum.ToString();
                }
                else
                {
                    if (Altinlar[baslangic] == Altinlar[bitis])
                    {
                        ayni = Altinlar[baslangic];
                        indis = baslangic;
                        baslangic++;
                        bitis--;
                    }
                    else
                    {
                        farkli = Altinlar[baslangic];
                        indis = baslangic;
                        //Farklı olan sayı diğer bütün sayılarla aynı ya da farklı olması kontrolü
                        if (ayni != farkli)
                            break;
                        else
                        {
                            farkli = Altinlar[bitis];
                            indis = bitis;
                            break;
                        }
                    }
                }
            }
            return "Altın Sayısı:" + this.AltinSayisi.ToString() + "\n" +
                    "Altın Numarası:" + (indis + 1).ToString() + "\n" +
                    "Ağırlığı:" + farkli.ToString() + "gr" + "\n" +
                    "Tartım Sayısı:" + KacinciOlcum.ToString();
        }
        public string CalismaZamani()
        {
            string saniye = "",mesaj="";
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            mesaj = HataliAltiniBul(Altinlar);
            stopWatch.Stop();
            TimeSpan t = stopWatch.Elapsed;
            saniye = t.TotalMilliseconds.ToString();
            return mesaj + "\n" +"Çalışma Zamanı:" + saniye; 
        }
    }
}

    