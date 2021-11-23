using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N50_DictionaryMetotOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContainsKey:Koleysiyon icindeki Key'lerde aranan deger varsa TRUE yoksa FALSE dondurur.
            //ContainsValue:Koleysiyon icindeki Value'larda aranan deger varsa TRUE yoksa FALSE dondurur.

            Dictionary<string, int> kisilerveDtarihleri = new Dictionary<string, int>();
            kisilerveDtarihleri.Add("Betül", 1990);
            kisilerveDtarihleri.Add("Ali", 1950);
            kisilerveDtarihleri.Add("Veli", 1987);
            kisilerveDtarihleri.Add("Lale", 2000);
            kisilerveDtarihleri.Add("Gül", 2000);
            kisilerveDtarihleri.Add("Ayşe", 2000);
            Console.WriteLine("İsminiz: ");
            string ad = Console.ReadLine();
            bool varMı = kisilerveDtarihleri.ContainsKey(ad);
            if (varMı)
            {
                int dYili = kisilerveDtarihleri[ad];
                int yas = DateTime.Now.Year - dYili;
                Console.WriteLine("Yaşı: "+yas);
            }
            else
            {
                Console.WriteLine("Bu deger koleksiyonunda yoktur.Eklemeniz için aşşağıdaki bilgileri doldurunuz.");
                Console.WriteLine(ad+"isimli kişinin dogum yılını giriniz");
                int dogumYılı = Convert.ToInt32(Console.ReadLine());
                kisilerveDtarihleri.Add(ad, dogumYılı);
                listele(kisilerveDtarihleri);
            }
            
            Console.ReadKey();
        }

        static void listele(Dictionary<string,int> liste)
        {
            Console.Clear();
            Console.WriteLine("Koleksiyonda "+liste.Count+" adet kayıt mevcuttur.");
            //dictionarydeki degerleri yazdırdık.
            foreach (KeyValuePair<string,int> item in liste)
            {
                Console.WriteLine(item.Key+"-"+item.Value);
            }

            foreach (var item in liste.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in liste.Values)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
