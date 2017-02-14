using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.RV.LIB;
namespace DerekDay2
{
    //DerekWS2
    public class Dice
    {
        private int faceUp;//variable

        public void Throw()//method1
        {
            faceUp = ISSMath.RNDInt(6);
        }

        public int GetFaceUp()//method1
        {
            return faceUp+1;
        }

        public string StrFaceUp//property
        {
            get
            {
                return Convert.ToString(faceUp+1);//dice range 0-5,so need 1-6
            }
        }

        public Dice()//constructor
        {
            Throw();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Dice d1 = new Dice();//create a new object

            //d1.Throw();
            //Console.WriteLine("d1: {0}", d1.StrFaceUp);
            //d1.Throw();
            //Console.WriteLine("d1: {0}", d1.StrFaceUp);
            //d1.Throw();
            //Console.WriteLine("d1: {0}", d1.StrFaceUp);

            Dice d2 = new Dice();//create another new object
            //d2.Throw();
            //Console.WriteLine("d2: {0}", d2.StrFaceUp);

            int sum = 0;
            int bingotimes = 0;
            Console.Write("What's your target: ", bingotimes);
            int yourtarget = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 100000; i++)
            {
                d1.Throw();
                //Console.WriteLine("d1: {0}", d1.GetFaceUp());
                d2.Throw();
                //Console.WriteLine("d2: {0}", d2.GetFaceUp());
                
                sum = d1.GetFaceUp() + d2.GetFaceUp();
                Console.WriteLine("sum: {0}", sum);
                if (sum == yourtarget)
                {
                    bingotimes += 1;
                    Console.WriteLine("bingotimes: {0}", bingotimes);
                }
            }
            
            Console.WriteLine("my probability: {0} / 100000", bingotimes);
            double myprobability = (Convert.ToDouble(bingotimes)) / 100000;
            Console.WriteLine("my probability: {0:0.00000}", myprobability);

        }
    }
}
