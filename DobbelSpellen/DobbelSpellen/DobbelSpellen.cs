using System;

namespace DobbelSpellen
{
    public static class Gooien
    {
        public static int[] GooiDobbelStenen()
        {
            int[] DobbelStenen = new int[3];
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            for (int i = 0; i < 3; i++)
            {
                DobbelStenen[i] = rnd.Next(1, 7);
            }

            return DobbelStenen;
        }
    }
}
