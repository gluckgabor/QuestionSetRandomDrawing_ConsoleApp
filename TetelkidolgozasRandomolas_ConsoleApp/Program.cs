using System;
using System.Collections.Generic;
using System.Linq;

namespace TetelkidolgozasRandomolas_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nevek tömbjének létrehozása
            string[] nameArray = new string[6];

            nameArray[0] = "Tüttő Tünde";
            nameArray[1] = "Szárföldi Júlia";
            nameArray[2] = "Zsembery Zita";
            nameArray[3] = "Cseh Judit";
            nameArray[4] = "Molnár Patrik";
            nameArray[5] = "Glück Gábor";
            
            Array.Sort(nameArray);

            //Tételtömb létrehozása
            int[] questionSetArray = new int[20];

            for (int i = 0; i <= 19; i++)
            {
                questionSetArray[i] = i + 1;
            }

            //Összekevert tétel-eredménytömb létrehozása
            Random rnd = new Random();
            questionSetArray = questionSetArray.OrderBy(x => rnd.Next()).ToArray();

            
            //Tételtömb egy adott embernél létrehozása
            int[] questionSetArrayAtPerson1 = new int[3];
            int[] questionSetArrayAtPerson2 = new int[3];
            int[] questionSetArrayAtPerson3 = new int[3];
            int[] questionSetArrayAtPerson4 = new int[3];
            int[] questionSetArrayAtPerson5 = new int[4];
            int[] questionSetArrayAtPerson6 = new int[4];

            for (int i = 0; i < questionSetArray.Length; i++)
            {
                if (i <= 2)
                {
                    questionSetArrayAtPerson1[i] = questionSetArray[i];
                }
                else if (i <= 5)
                {
                    questionSetArrayAtPerson2[i - 3] = questionSetArray[i];
                }
                else if (i <= 8)
                {
                    questionSetArrayAtPerson3[i - 6] = questionSetArray[i];
                }
                else if (i <= 11)
                {
                    questionSetArrayAtPerson4[i - 9] = questionSetArray[i];
                }
                else if (i <= 15)
                {
                    questionSetArrayAtPerson5[i - 12] = questionSetArray[i];                    
                }
                else
                {
                    questionSetArrayAtPerson6[i - 16] = questionSetArray[i];
                }
            }

            
            //Eredmény kiiratása
            foreach (var item in nameArray.Select((value, i) => new { i, value }))
            {
                Console.WriteLine(item.value + " megnyerte a köv. tételek kidolgozását:");

                switch (item.i)
                {
                    case 0:
                        for (int i = 0; i < questionSetArrayAtPerson1.Length; i++)
                        {
                            Console.Write(questionSetArrayAtPerson1[i].ToString());
                            Console.Write(", ");
                        }
                        break;
                    case 1:
                        for (int i = 0; i < questionSetArrayAtPerson2.Length; i++)
                        {
                            Console.Write(questionSetArrayAtPerson2[i].ToString());
                            Console.Write(", ");
                        }
                        break;
                    case 2:
                        for (int i = 0; i < questionSetArrayAtPerson3.Length; i++)
                        {
                            Console.Write(questionSetArrayAtPerson3[i].ToString());
                            Console.Write(", ");
                        }
                        break;
                    case 3:
                        for (int i = 0; i < questionSetArrayAtPerson4.Length; i++)
                        {
                            Console.Write(questionSetArrayAtPerson4[i].ToString());
                            Console.Write(", ");
                        }
                        break;
                    case 4:
                        for (int i = 0; i < questionSetArrayAtPerson5.Length; i++)
                        {
                            Console.Write(questionSetArrayAtPerson5[i].ToString());
                            Console.Write(", ");
                        }
                        break;
                    case 5:
                        for (int i = 0; i < questionSetArrayAtPerson6.Length; i++)
                        {
                            Console.Write(questionSetArrayAtPerson6[i].ToString());
                            Console.Write(", ");
                        }
                        break;
                }               
                Console.WriteLine("\r\n");
            }
            Console.ReadLine();
        }
    }
}
