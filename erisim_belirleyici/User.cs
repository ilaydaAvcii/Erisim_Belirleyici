using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erisim_Belirleyici.Erisim
{
    public class User
    {
        private string adSoyad;
        private int yas;

        public string Email { get; set; }

        public string GetAdSoyad()
        {
            return adSoyad;
        }
        public void SetAdSoyad(string yeniAdSoyad)
        {
            if (!string.IsNullOrWhiteSpace(yeniAdSoyad)) // Boş değer engellendi
            {
                adSoyad = yeniAdSoyad;
            }
            else
            {
                Console.WriteLine("Ad Soyad boş olamaz!");
            }
        }
        public int GetYas()
        {
            return yas;

        }
        public void SetYas(int yeniYas)
        {
            yas = yeniYas;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine($"Ad Soyad: {adSoyad}");
            Console.WriteLine($"Yaş: {yas}");
            Console.WriteLine($"E-mail: {Email}");
        }
    }
}