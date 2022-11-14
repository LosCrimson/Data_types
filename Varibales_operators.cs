using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2022_11_14_data_types
{
    public class Varibales_operators
    {
        //PARAŠYTIPROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI GRUPĖS NARIŲ KIEKĮ.
        //JEI NARIŲ KIEKIS LYGUS 1 PROGRAMA IŠVEDA „TAI SOLOATLIKĖJAS“, 
        //JEI NARIŲ KIEKIS 2 -„TAI DUETAS“, JEI NARIŲ KIEKIS DAUGIAU NEI 
        //2 BET MAŽIAU NEI 10 –„TAI ANSAMBLIS“, JEI DAUGIAU NEI 10 –„TAI 
        //KAMERINIS ANSAMBLIS“.JEI VARTOTOJAS PADARO ĮVEDIMO KLAIDĄ 
        //–PRANEŠTI IR UŽBAIGTI DARBĄ

        public void determine_band_size_name()
        {
            int performers_number;
            Console.WriteLine("Enter band size: ");
            try
            {
                performers_number = Convert.ToInt32(Console.ReadLine());
            } catch {Console.WriteLine("Jobs done"); Console.ReadLine(); throw; }

            if (performers_number == 1)
            { Console.WriteLine("Solo artist"); }
           else if(performers_number == 2)
                    { Console.WriteLine("Duet artists"); Console.ReadLine(); }
            else if(performers_number > 2 && performers_number < 11)
                    { Console.WriteLine("Ensemble artists"); Console.ReadLine(); }
            else if(performers_number > 10)
                    { Console.WriteLine("Chambered ensemble"); Console.ReadLine(); }
            else if (!double.IsNaN(performers_number))
                    { Console.WriteLine("Jobs done"); Console.ReadLine(); }
            
        }

    }
}
