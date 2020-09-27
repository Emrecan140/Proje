using System;

namespace Proje
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Console.Write("İlk değeri giriniz: ");
        int a= Convert.ToInt32(Console.ReadLine());
        Console.Write("İkinci değeri giriniz: ");
        int b= Convert.ToInt32(Console.ReadLine());

        

        if(a > b){
            Console.Write(a + " büyüktür " + b + " den");

        }else if(a == b){
            Console.Write(a + " eşittir " + b + " ye ");
        }
        else {
            Console.Write(a + " küçüktür " + b + " den");


        }
  

        Console.Write("Ne almak istersiniz: ");
        string deger = Console.ReadLine();
        Console.Write("Bir sayı giriniz: ");
        int sayı = Convert.ToInt32(Console.ReadLine());
        if(deger == "kök"){
            
            Console.Write(Math.Sqrt(sayı));


        }else if(deger == "üst" ){

            Console.Write("Kaçıncı üstünü almak istersiniz: ");

            int üst = Convert.ToInt32(Console.ReadLine());

            Console.Write(Math.Pow(sayı, üst));

        }else {

            Console.Write("Hatalı girdiniz.");
        }
*/
        Console.Write("Ne almak istersiniz: ");
        string deger = Console.ReadLine();
        Console.Write("Bir sayı giriniz: ");
        int sayı = Convert.ToInt32(Console.ReadLine());
        switch(deger){
            case "kök":
                Console.Write(Math.Sqrt(sayı));
            break;
            case "üst":
            Console.Write("Kaçıncı üstünü almak istersiniz: ");

            int üst = Convert.ToInt32(Console.ReadLine());

            Console.Write(Math.Pow(sayı, üst));
            break;

            default: 
            Console.Write("Hatalı girdiniz: ");
            break;


        }

        }

        


        
            

        
    }
}
