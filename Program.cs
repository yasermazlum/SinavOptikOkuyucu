string dosyaYolu = "D:/a.txt";

string[] satirlar = File.ReadAllLines(dosyaYolu);
string cevapSatiri = satirlar[0].Trim().Substring(56, 80);

for (int i = 1; i < satirlar.Length; i ++)
{
    string sira = satirlar[i];
    string sinavNo = sira.Substring(0, 3);
    string ogrenciNo = sira.Substring(11, 5);
    string ogrenciAdi = sira.Substring(16, 19);
    string ogrenciTcNo = sira.Substring(36, 11);
    string ogrenciSinifNo = sira.Substring(47, 4);
    string ogrenciCevaplari = sira.Substring(56, 80);


    int dogruSayisi = 0;
    int yanlisSayisi = 0;
    int bosSoruSayisi = 0;

    for (int j = 0; j < cevapSatiri.Length; j++)
    {
        if (ogrenciCevaplari[j] == ' ')
        {
            bosSoruSayisi++;
        }
        else if (ogrenciCevaplari[j] == cevapSatiri[j])
        {
            dogruSayisi++;
        }
        else
        {
            yanlisSayisi++;
        }
    }

    Console.WriteLine($"Sınav Kodu: {sinavNo}");
    Console.WriteLine($"Sınıf Numarası: {ogrenciSinifNo}");
    Console.WriteLine($"Öğrenci No: {ogrenciNo}");
    Console.WriteLine($"Öğrenci TC: {ogrenciTcNo}");
    Console.WriteLine($"Öğrenci Adı: {ogrenciAdi}");
    Console.WriteLine($"Doğru Sayısı: {dogruSayisi}");
    Console.WriteLine($"Yanlış Sayısı: {yanlisSayisi}");
    Console.WriteLine($"Boş Soru Sayısı: {bosSoruSayisi}");
    Console.WriteLine();
}