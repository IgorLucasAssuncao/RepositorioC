/*using System;

namespace Lista14
{
    class Lista14
    {

        public static void preenche(int[] vetNotas)
        {
            Random rd = new Random();
            for (int i = 0; i < vetNotas.Length; i++)
            {
                vetNotas[i] = rd.Next(0, 11);
            }
        }

        public static float media(int[] vetNotas)
        {
            float media = 0;
            for (int i = 0; i < vetNotas.Length; i++)
            {
                media += vetNotas[i];
            }
            media /= vetNotas.Length;
            return media;
        }
        public static int acimaMedia(int[] vetNotas, float media)
        {
            int acimaMedia = 0;
            for (int i = 0; i < vetNotas.Length; i++)
            {
                if (vetNotas[i] > media)
                {
                    acimaMedia++;
                }
            }
            return acimaMedia;
        }

        public static void Main(string[] args)
        {
            int[] vetNotas = new int[10];
            int AcimaDaMedia = 0;
            preenche(vetNotas);
            media(vetNotas);
            AcimaDaMedia = acimaMedia(vetNotas, media(vetNotas));
        }
    }
}
*/