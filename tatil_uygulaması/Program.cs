
// Nereye gitmek istediği sorulur
Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)\r\n\r\n2 - Marmaris (Paket başlangıç fiyatı 3000 TL)\r\n\r\n3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");
Console.Write("Nereye gitmek istiyorsunuz ?");

//Gitmek istediği yer bir değişkende tutulur
string yer = Console.ReadLine().ToLower();

//Eğer gitmek istediği yer ile ilgili hatalı bilgi girdiyse doğrusunu girene kadar sorulur
while(yer != "bodrum" && yer != "marmaris" && yer != "çeşme")
{

    Console.WriteLine("\nYanlış yer tercihi yaptınız ! Lütfen aşağıdaki seçeneklerden tekrar deneyin");
    Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)\r\n\r\n2 - Marmaris (Paket başlangıç fiyatı 3000 TL)\r\n\r\n3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");
    Console.Write("Nereye gitmek istiyorsunuz ? \n");
    yer = Console.ReadLine().ToLower();
}

//girdiği yer bilgisine göre yer için ödeyeceği toplam tutar
float yer_toplam=0;
switch (yer)
{
    case "bodrum":
        yer_toplam = 4000;
        break;
    case "marmaris":
        yer_toplam = 3000;
        break;
    case "çeşme":
        yer_toplam = 5000;
        break;
}


//Kişi sayısı bir değişkende tutulur
Console.Write("Kaç kişi gitmek istiyorsunuz ?");
int kisi_sayısı = Convert.ToInt32(Console.ReadLine());

//Özet bilgi
Console.WriteLine($"Tatile {kisi_sayısı} kişi olarak {yer} ' e gitmak istiyorsunuz");


//Tatile gitmek istediği yol
Console.WriteLine("Tatile hangi yolla gitmek istiyorsunuz ?");
Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )\r\n\r\n2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)\nLütfen yukarıdaki seçeneklerden bir tanesini seçiniz");
string yol_secenek = Console.ReadLine().ToLower();


//Gitmek istediği yol seçeneğini yanlış girerse doğrusunu girene kadar sorar
while (yol_secenek != "1" && yol_secenek != "2")
{

    Console.WriteLine("\nYanlış yer tercihi yaptınız ! Lütfen aşağıdaki seçeneklerden tekrar deneyin");
    Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )\r\n\r\n2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)\nLütfen yukarıdaki seçeneklerden bir tanesini seçiniz");
    Console.Write("Tatile hangi yolla gitmek istiyorsunuz ?");
    yol_secenek = Console.ReadLine().ToLower();
}

//Yol için ödeyeceği toplam tutar hesaplanır
float yol_toplam=0;
switch (yol_secenek)
{
    case "1":
        yol_toplam = kisi_sayısı * 1500;
        break;
    case "2":
        yol_toplam = kisi_sayısı * 4000;
        break;
}

//Toplam tatil ücreti hesaplanır
float toplam = yer_toplam + yol_toplam;

Console.WriteLine($"Toplam tatil harcamanız : {toplam}");
