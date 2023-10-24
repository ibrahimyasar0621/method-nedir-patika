using System.Net.Http.Headers;

namespace method_nedir;

class Program
{
    static void Main(string[] args)
    {
        // erisim_belirteci geri_donustipi  metot_adi(parametre/argüman)
        // ERİŞİM BELİRTECİ= bu metodun nereden erişilebileciğinden bahsediyoruz. Bir metodu public tanımlarsan her yerden erişilebilir olur. Metodu privite tanımlarsan sadece var olduğu class içerisinden değişiklik yapabilirsin. 
        //GERİ DÖNÜŞ TİPİ= bu metod bir şey yaptıktan sonra geriye dönecek mi yada çağrıldığı yerden bir şeye ihtiyaç duyuluyor mu? Her metodun geri dönüşü olmaz geri dönüşsüz metodlarda yazılabilir. geri dönüşsüz metod yazılacaksa  void yazmamıız lazım . bu geri dönüşün imzasına ait bilgidir. geri dönüş olmayacaksa bile void yazmamız lazım.
        //METOD ADI=  Metoda ne isim veriyorsak odur. Bizim metodun adına bakarak kodlarına bakmadan bu metodun ne iş yaptığını bilmem gerekiyor. İsminden ne kadar anlarsam okadar temiz kod olmuş oluyor.
        //PARAMETRE LİSTESİ= Diğer adı argümandır. Bu metodun iş yaparken kullanacağı parametreler. hangileri üzerinde değişiklik yapacağız. Eğer geri dönüş yapacaksak [ RETURN ]  kullanmalıyız.
        // {
           // komutlar;
        // }


        //İKİ SAYIYI TOPLAYAN BİR KOD YAZDIK. SONRA AYNISINI METOD İLE YAZACAĞIZ. AYNI CLASS İÇİNDE YAZACAĞIZ. 
        int a=2;
        int b=3;
        Console.WriteLine(a+b);

        int sonuc(a,b);
        Console.WriteLine(sonuc);
        metodlar ornek = new metodlar();
        ornek.EkranaYazdir(Convert.ToString(sonuc));


    }
    static int Topla(int deger1, int deger2);
    {
        return (deger1 + deger2);
    }
}

class metodlar
void EkranaYazdir(string veri);
{
    Console.WriteLine(sonuc);
}
