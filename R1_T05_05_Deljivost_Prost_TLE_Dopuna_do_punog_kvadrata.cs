// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka3/dopuna_do_punog_kvadrata
// https://petlja.org/sr-Latn-RS/biblioteka/r/problemi/Zbirka-stara/dopuna_do_punog_kvadrata
// https://arena.petlja.org/sr-Latn-RS/competition/r1-t05-deljivost-prosti-tle-001-2024#tab_132802
// https://petlja.org/sr-Latn-RS/kurs/14606/23/2756
// https://github.com/draganilicnis/R1_T05_05_Deljivost_Prost_TLE_Dopuna_do_punog_kvadrata/blob/main/R1_T05_05_Deljivost_Prost_TLE_Dopuna_do_punog_kvadrata.cs


using System;

class R1_T05_05_Deljivost_Prost_TLE_Dopuna_do_punog_kvadrata
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        long m = 1;

        long d = 2;  
        while (d * d <= n)
        {
            int k = 0;
            while (n % d == 0)
            {
                n = n / d;
                k++;
            }
            if (k % 2 != 0) m = m * d;
            d++;
        }
        if (n > 1) m = m * n;
        
        Console.WriteLine(m);
    }
}
