using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class PersonelManager : IPersonel
    {
        public void Create()
        {
            Console.WriteLine("New personel created");
        }

        public void Delete()
        {
            Console.WriteLine("Personel deleted");
        }

        public void Read()
        {
            Console.WriteLine("Personel info read");
        }

        public void Update()
        {
            Console.WriteLine("Personel Info is updated");
        }
    }
}
