// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using Erisim_Belirleyici.Erisim;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {

        User kullanici = new User();

        kullanici.SetAdSoyad("İlayda Avcı");
        kullanici.SetYas(20);
        kullanici.Email = "ilaydaavci26@gmail.com";

        kullanici.BilgileriGoster();
    }
}

//Erişim Belirleyicilerin OOP’deki Rolü
//1)  Kapsülleme (Encapsulation): Veri saklama ve güvenliğini sağlar. private ve protected kullanımıyla dış erişim sınırlandırılır.
//2)  Kodun Yönetilebilirliğini Artırma: public ve internal ile modüler bir yapı oluşturulabilir, kod tekrarını önler.
//3)  Miras (Inheritance) Kontrolü: protected ile alt sınıflara özel erişim tanımlanabilir.
//4)  Daha Güvenli Yazılım Geliştirme: Hassas verilerin (private) dışarıdan değiştirilmesini önler, böylece hatalara ve saldırılara karşı koruma sağlar.
//
//1. public (Genel):Bir üyeye(metod, değişken vb.) herkes erişebilir. Farklı sınıflardan veya projelerden çağrılabilir.
//2. private (Özel): Sadece tanımlandığı sınıf içerisinden erişilebilir. Dışarıdan erişime kapalıdır
//3. protected (Korunan): Sadece tanımlandığı sınıf ve o sınıftan türeyen alt sınıflar tarafından erişilebilir.
//4. internal (Dahili): Aynı proje(assembly) içerisindeki tüm sınıflardan erişilebilir, ancak farklı projelerden erişilemez.