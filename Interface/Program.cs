using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonelManager personel = new PersonelManager();

            personel.Create();
            personel.Read();
            personel.Update();
            personel.Delete();
        }
    }
}
