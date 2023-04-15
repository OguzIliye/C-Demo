using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dörtİşlem dörtİşlem = new Dörtİşlem(2, 3);
            //Console.WriteLine(dörtİşlem.Topla2());

            var type = typeof(Dörtİşlem);
            Dörtİşlem dörtİşlem=(Dörtİşlem)Activator.CreateInstance(type);
            Console.WriteLine(dörtİşlem.Topla(6,9));

            Console.ReadLine();
        }
    }
    class Dörtİşlem
    {
        private int _sayı1;
        private int _sayı2;

        public Dörtİşlem(int sayı1, int sayı2)
        {
            _sayı1 = sayı1;
            _sayı2 = sayı2;
        }
        public Dörtİşlem()
        {

        }
        public int Topla(int sayı1, int sayı2)
        {
            return sayı1 + sayı2;
        }
        public int Çarp(int sayı1, int sayı2)
        {
            return sayı1 * sayı2;
        }
        public int Topla2()
        {
            return _sayı1 + _sayı2;
        }
        public int Çarp2()
        {
            return _sayı1 * _sayı2;
        }
    }
}
