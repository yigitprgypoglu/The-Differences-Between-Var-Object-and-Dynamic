using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // "var" i neye atarsak onun gibi davranir yani egerki var x = "st" dedigimiz zaman iceri kelime yazdigimiz icin string gibi davranir
            // "var" i genellikle gelecek degisken turunu bilmedigimiz zaman kullaniriz
            /*not var x="str" yaptigimizda artik x=10 diyemeyiz cunku x degiskenimiz string olarak kesinlesti ve sonradan degiskeni degisemez
            ama egerki object de ayni seyi yaparsak hata almayiz object bunu kabul eder ama object de unboxing gerektigi icin egerki unboxing
            yaparken yanlis degisken cagirilirsa program hata verir.

             */
            var x = "str";
            var y = 10;
            //
            object z= 5;
            int a = (int)z; // unboxing yaptik (int) yazmasaydik hata vericekti.
            //
            dynamic b = 5;
            dynamic c = "selam";

            string g = c;//herhangi bi sorun yok ama onerilen (string) yazip unboxing yapmaktir.
            //object veri = "Merhaba";
            // Console.WriteLine(veri.Length); // HATA: object tipinin 'Length' özelliği yoktur.
           //Console.WriteLine(((string)veri).Length); // CAST (Dönüştürme) ile çalışır.

            dynamic veri = "Merhaba";
            Console.WriteLine(veri.Length); // HATA VERMEZ! Runtime'da 'Length' özelliğini arar ve bulur.

            veri = 10;
            // Console.WriteLine(veri.Length); // Runtime hatası: int tipinde 'Length' özelliği yoktur
            // bu durum object de olsaydi aninda kod ekraninda hata vericekti ama dynamic de hatayi kodu calistirdiktan sonra aliriz.
        }
    }
}
