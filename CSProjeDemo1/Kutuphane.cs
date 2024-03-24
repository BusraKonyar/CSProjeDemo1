using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Kutuphane 
    {
        private List<Kitap> kitaplar;
        private List<Uye> uyeler;

        public Kutuphane()
        {
            kitaplar = new List<Kitap>();
            uyeler = new List<Uye>();
        }

        public void KitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
        }

        public void UyeEkle(Uye uye)
        {
            uyeler.Add(uye);
        }

        public void KitapOduncAl(Uye uye, Kitap kitap)
        {
            if (kitap.Durum != Durum.OduncAlinabilir)
            {
                Console.WriteLine("Kitap şu anda ödünçte veya mevcut değil.");
                return;
            }

            kitap.Durum = Durum.Oduncte;
            uye.OduncKitaplar.Add(kitap);
            Console.WriteLine($"{kitap.Baslik} kitabı {uye.Ad} {uye.Soyad} tarafından ödünç alındı.");
        }

        public void KitapIadeEt(Uye uye, Kitap kitap)
        {
            if (!uye.OduncKitaplar.Contains(kitap))
            {
                Console.WriteLine($"{kitap.Baslik} kitabı {uye.Ad} {uye.Soyad}'ın elinde değil.");
                return;
            }

            kitap.Durum = Durum.OduncAlinabilir;
            uye.OduncKitaplar.Remove(kitap);
            Console.WriteLine($"{kitap.Baslik} kitabı {uye.Ad} {uye.Soyad} tarafından iade edildi.");
        }

        public void KitapDurumuGuncelle(Kitap kitap, Durum durum)
        {
            kitap.Durum = durum;
        }

        public void UyeninOduncAldigiKitaplariGoruntule(Uye uye)
        {
            Console.WriteLine($"{uye.Ad} {uye.Soyad}'ın ödünç aldığı kitaplar:");
            foreach (var kitap in uye.OduncKitaplar)
            {
                Console.WriteLine(kitap.Baslik);
            }
        }

        public void KutuphaneDurumunuGoruntule()
        {
            Console.WriteLine("Kütüphane Durumu:");
            Console.WriteLine($"Mevcut Kitaplar: {kitaplar.Count(k => k.Durum == Durum.OduncAlinabilir)} adet");
            Console.WriteLine($"Ödünç Alınan Kitaplar: {kitaplar.Count(k => k.Durum == Durum.Oduncte)} adet");
            Console.WriteLine($"Üye Sayısı: {uyeler.Count} adet");
        }
    }
}
