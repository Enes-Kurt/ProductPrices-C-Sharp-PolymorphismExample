using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPrices
{
    public class Ürün
    {
        // public List<int> SayiList => new List<int>();
        public string Adı { get; set; }
        public int Kodu { get; set; }
        public int Fiyatı { get; set; }
        public string ÜrünKalitesi { get; set; }
        public int TüketimMiktarı { get; set; }

        public string ÜretimMaddesi { get; set; }

        protected static double KDV = 1.18;
        protected static double SaatlikElektrikFiyatı = 1.98;
        virtual public double EnerjiTüketimi()
        {
            return TüketimMiktarı * SaatlikElektrikFiyatı;
        }
        virtual public double KDVliFiyat()
        {
            return Fiyatı * KDV;
        }

    }

    public class BeyazEşya : Ürün
    {
        // Enerji tüketimi elektronik ürün ve beyazeşya için aynı.

        override public double KDVliFiyat()
        {
            // Beyaz eşya ürünlerde firma ek %15 ücret alıyor
            return Fiyatı * KDV * 1.15;
        }

    }
    public class Mobilya : Ürün
    {
        // Mobilya eşya ürünlerde firma standart ücret alıyor.(Sadece KDV var)

        // Enerji tüketimi mobilyada olmadığı için 0 olmalı.
        override public double EnerjiTüketimi()
        {
            return 0;
        }
    }

    public class Elektronik : Ürün
    {
        // Enerji tüketimi elektronik ürün ve beyazeşya için aynı.
        override public double KDVliFiyat()
        {
            // Elektronik eşya ürünlerde firma ek %30 ücret alıyor
            return Fiyatı * KDV * 1.30;
        }
    }




    internal class Program
    {
        static void ÜrünEkle()
        {
            Console.WriteLine("Eklemek istediğiniz ürünü seçiniz:\n1-BeyazEşya\n2-Mobilya\n3-Elektronik");
            int secim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kaç adet ürün ekleyecepinizi yazınız.");
            int adet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n---------------Ürün Bilgi Girişi---------------\n");
        aşama1:
            if (secim == 1)
            {
                Ürün[] ürün = new BeyazEşya[adet];

                for (int i = 0; i < adet; i++)
                {
                    ürün[i] = new BeyazEşya();
                    Console.Write($"{i+1}. Ürün adını giriniz: ");
                    ürün[i].Adı = Convert.ToString(Console.ReadLine());
                    Console.Write($"{i + 1}. Ürün kodunu giriniz: ");
                    ürün[i].Kodu = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"{i + 1}. Ürün fiyatını giriniz: ");
                    ürün[i].Fiyatı = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"{i + 1}. Ürün kalitesi giriniz: ");
                    ürün[i].ÜrünKalitesi = Convert.ToString(Console.ReadLine());
                    Console.Write($"{i + 1}. Ürün üretim maddesini giriniz: ");
                    ürün[i].ÜretimMaddesi = Convert.ToString(Console.ReadLine());
                    Console.Write($"{i + 1}. Ürün tüketim mikatarını giriniz: ");
                    ürün[i].TüketimMiktarı = Convert.ToInt32(Console.ReadLine());
                    if(i < adet - 1) Console.WriteLine("\n---------------Sıradaki Ürün---------------\n");


                    if (i == adet - 1)
                    {
                        Console.WriteLine("\n---------------Ürün Görüntüleme---------------\n");
                        Console.WriteLine("Görüntülemek istediğiniz ürünün Kodunu giriniz:");
                        int ürünkodu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"\n---------------{ürünkodu} Kodlu Ürünün Bilgileri---------------\n");
                        for (int k = 0; k < adet; k++)
                        {
                            if (ürünkodu == ürün[k].Kodu)
                            {
                                Console.WriteLine("Ürün adı: {0}", ürün[k].Adı);
                                Console.WriteLine("Ürün kodu: {0}", ürün[k].Kodu);
                                Console.WriteLine("Ürün fiyatı: {0}", ürün[k].Fiyatı);
                                Console.WriteLine("Ürün kalitesi: {0}", ürün[k].ÜrünKalitesi);
                                Console.WriteLine("Ürün üretim maddesi: {0}", ürün[k].ÜretimMaddesi);
                                Console.WriteLine("Ürün saatlik enerji tüketimi miktarı: {0} KW", ürün[k].TüketimMiktarı);
                                Console.WriteLine("Ürün KDV'li fiyatı: {0}", ürün[k].KDVliFiyat());
                                Console.WriteLine("Ürün saatlik enerji tüketim fiyatı: {0} TL", ürün[k].EnerjiTüketimi());

                            }
                        }
                    }
                }
            }
            else if (secim == 2)
            {
                Ürün[] ürün = new Mobilya[adet];

                for (int i = 0; i < adet; i++)
                {
                    ürün[i] = new Mobilya();
                    Console.Write($"{i + 1}. Ürün adını giriniz: ");
                    ürün[i].Adı = Convert.ToString(Console.ReadLine());
                    Console.Write($"{i + 1}. Ürün kodunu giriniz: ");
                    ürün[i].Kodu = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"{i + 1}. Ürün fiyatını giriniz: ");
                    ürün[i].Fiyatı = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"{i + 1}. Ürün kalitesi giriniz: ");
                    ürün[i].ÜrünKalitesi = Convert.ToString(Console.ReadLine());
                    Console.Write($"{i + 1}. Ürün üretim maddesini giriniz: ");
                    ürün[i].ÜretimMaddesi = Convert.ToString(Console.ReadLine());
                    if (i < adet - 1) Console.WriteLine("\n---------------Sıradaki Ürün---------------\n");




                    if (i == adet - 1)
                    {
                        Console.WriteLine("\n---------------Ürün Görüntüleme---------------\n");
                        Console.WriteLine("Görüntülemek istediğiniz ürünün Kodunu giriniz:");
                        int ürünkodu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"\n---------------{ürünkodu} Kodlu Ürünün Bilgileri---------------\n");

                        for (int k = 0; k < adet; k++)
                        {
                            if (ürünkodu == ürün[k].Kodu)
                            {
                                Console.WriteLine("Ürün adı: {0}", ürün[k].Adı);
                                Console.WriteLine("Ürün kodu: {0}", ürün[k].Kodu);
                                Console.WriteLine("Ürün fiyatı: {0}", ürün[k].Fiyatı);
                                Console.WriteLine("Ürün kalitesi: {0}", ürün[k].ÜrünKalitesi);
                                Console.WriteLine("Ürün üretim maddesi: {0}", ürün[k].ÜretimMaddesi);
                                Console.WriteLine("Ürün saatlik enerji tüketimi miktarı: {0} KW", ürün[k].TüketimMiktarı);
                                Console.WriteLine("Ürün KDV'li fiyatı: {0}", ürün[k].KDVliFiyat());
                                Console.WriteLine("Ürün saatlik enerji tüketim fiyatı: {0} TL", ürün[k].EnerjiTüketimi());

                            }
                        }
                    }
                }

            }
            else if (secim == 3)
            {
                Ürün[] ürün = new Elektronik[adet];

                for (int i = 0; i < adet; i++)
                {
                    ürün[i] = new Elektronik();
                    Console.Write($"{i + 1}. Ürün adını giriniz: ");
                    ürün[i].Adı = Convert.ToString(Console.ReadLine());
                    Console.Write($"{i + 1}. Ürün kodunu giriniz: ");
                    ürün[i].Kodu = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"{i + 1}. Ürün fiyatını giriniz: ");
                    ürün[i].Fiyatı = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"{i + 1}. Ürün kalitesi giriniz: ");
                    ürün[i].ÜrünKalitesi = Convert.ToString(Console.ReadLine());
                    Console.Write($"{i + 1}. Ürün üretim maddesini giriniz: ");
                    ürün[i].ÜretimMaddesi = Convert.ToString(Console.ReadLine());
                    Console.Write($"{i + 1}. Ürün tüketim mikatarını giriniz: ");
                    ürün[i].TüketimMiktarı = Convert.ToInt32(Console.ReadLine());
                    if (i < adet - 1) Console.WriteLine("\n---------------Sıradaki Ürün---------------\n");


                    if (i == adet - 1)
                    {
                        Console.WriteLine("\n---------------Ürün Görüntüleme---------------\n");
                        Console.WriteLine("Görüntülemek istediğiniz ürünün Kodunu giriniz:");
                        int ürünkodu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"\n---------------{ürünkodu} Kodlu Ürünün Bilgileri---------------\n");
                        for (int k = 0; k < adet; k++)
                        {
                            if (ürünkodu == ürün[k].Kodu)
                            {
                                Console.WriteLine("Ürün adı: {0}", ürün[k].Adı);
                                Console.WriteLine("Ürün kodu: {0}", ürün[k].Kodu);
                                Console.WriteLine("Ürün fiyatı: {0}", ürün[k].Fiyatı);
                                Console.WriteLine("Ürün kalitesi: {0}", ürün[k].ÜrünKalitesi);
                                Console.WriteLine("Ürün üretim maddesi: {0}", ürün[k].ÜretimMaddesi);
                                Console.WriteLine("Ürün saatlik enerji tüketimi miktarı: {0} KW", ürün[k].TüketimMiktarı);
                                Console.WriteLine("Ürün KDV'li fiyatı: {0}", ürün[k].KDVliFiyat());
                                Console.WriteLine("Ürün saatlik enerji tüketim fiyatı: {0} TL", ürün[k].EnerjiTüketimi());

                            }
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız lütfen 1,2 veya 3 şeklinde seçim yapınız.");
                goto aşama1;
            }

        }
    

        static void Main(string[] args)
        {
            ÜrünEkle();

            Console.ReadLine();
        }
    }

}







