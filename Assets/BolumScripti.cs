using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolumScripti : MonoBehaviour
{
    void bolenleriBul(int ilksayi, int ikincisayi)
    {

        List<int> listeAdi = new List<int>();
        List<int> ikiyeBolunenler = new List<int>();
        List<int> uceBolunenler = new List<int>();
        List<int> dorteBolunenler = new List<int>();
        List<int> beseBolunenler = new List<int>();


        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            // tüm listeyi yazar
            listeAdi.Add(i);


            //ikiye bölünenleri kontrol eder ve listeye atar
            if (i % 2 == 0)
            {
                ikiyeBolunenler.Add(i);
            }

            //üçe bölünenleri kontrol eder ve listeye atar
            if (i % 3 == 0)
            {
                uceBolunenler.Add(i);
            }

            //dörte bölünenleri kontrol eder ve listeye atar
            if (i % 4 == 0)
            {
                dorteBolunenler.Add(i);
            }

            //beþe bölünenleri kontrol eder ve listeye atar
            if (i % 5 == 0)
            {
                beseBolunenler.Add(i);
            }

        }
        // listedeki tüm elemanlarý konsola yazar
        foreach (int eleman in listeAdi)
        {
            print("listedeki tüm elemanlar - " + eleman);
        }

        // ikiye bölünen elemanlarý konsola yazar
        foreach (int iki in ikiyeBolunenler)
        {
            print("ikiye bölünenler - " + iki);

        }

        // üçe bölünen elemanlarý konsola yazar
        foreach (int uc in uceBolunenler)
        {
            print("üçe bölünenler - " + uc);

        }

        // dörte bölünen elemanlarý konsola yazar
        foreach (int dort in dorteBolunenler)
        {
            print("dörte bölünenler - " + dort);

        }

        // beþe bölünen elemanlarý konsola yazar
        foreach (int bes in beseBolunenler)
        {
            print("beþe bölünenler - " + bes);

        }


    }

    void Start()
    {


        bolenleriBul(5, 30);

    }
}
