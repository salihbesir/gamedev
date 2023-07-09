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
            // t�m listeyi yazar
            listeAdi.Add(i);


            //ikiye b�l�nenleri kontrol eder ve listeye atar
            if (i % 2 == 0)
            {
                ikiyeBolunenler.Add(i);
            }

            //��e b�l�nenleri kontrol eder ve listeye atar
            if (i % 3 == 0)
            {
                uceBolunenler.Add(i);
            }

            //d�rte b�l�nenleri kontrol eder ve listeye atar
            if (i % 4 == 0)
            {
                dorteBolunenler.Add(i);
            }

            //be�e b�l�nenleri kontrol eder ve listeye atar
            if (i % 5 == 0)
            {
                beseBolunenler.Add(i);
            }

        }
        // listedeki t�m elemanlar� konsola yazar
        foreach (int eleman in listeAdi)
        {
            print("listedeki t�m elemanlar - " + eleman);
        }

        // ikiye b�l�nen elemanlar� konsola yazar
        foreach (int iki in ikiyeBolunenler)
        {
            print("ikiye b�l�nenler - " + iki);

        }

        // ��e b�l�nen elemanlar� konsola yazar
        foreach (int uc in uceBolunenler)
        {
            print("��e b�l�nenler - " + uc);

        }

        // d�rte b�l�nen elemanlar� konsola yazar
        foreach (int dort in dorteBolunenler)
        {
            print("d�rte b�l�nenler - " + dort);

        }

        // be�e b�l�nen elemanlar� konsola yazar
        foreach (int bes in beseBolunenler)
        {
            print("be�e b�l�nenler - " + bes);

        }


    }

    void Start()
    {


        bolenleriBul(5, 30);

    }
}
