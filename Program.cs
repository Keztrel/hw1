using System;

namespace Homework {
     class Program {            
          static void Main(string[] args) {
          Console.WriteLine( "Enter Password : " );
          int psw = int.Parse(Console.ReadLine());
          Console.WriteLine( "Enter Unit : " );
          string Unit = Console.ReadLine();

            if (psw >= 100000 && psw <= 999999) {

                    int pw000000 = psw / 100000;
                    psw = psw - (pw000000 % 100000);

                    int pw00000 = psw / 10000;
                    psw = psw - (pw00000 % 10000);

                    int pw0000 = psw / 1000;
                    psw = psw - (pw0000 % 1000);

                    int pw000 = psw / 100;
                    psw = psw - (pw000 % 100);

                    int pw00 = psw / 10;
                    psw = psw - (pw00 % 10);

                    int pw0 = psw / 1;
                    psw = psw - (pw0 % 10);

            if (( Unit == "CIA")) {
                    if (pw0 % 3 == 0 && pw00 !=1 || pw00 !=3 || pw00 !=5 && pw0000 >= 6 && pw0000 !=8) {

                                Console.WriteLine ( "True" ); 

                             }
                        else {
                                Console.WriteLine ( "False" );

                                }
                }
            if (( Unit == "FBI")) {
                    if (pw000000 >= 4 && pw000000 <= 7 && pw000 % 2 == 0 && pw000 !=6 && pw00000 == 1 || pw00000 == 3 || pw00000 == 5 || pw00000 == 7 || pw00000 == 9) {

                                Console.WriteLine( "True" );

                             }
                        else {

                                Console.WriteLine( "False" );

                                }
                }
            if (( Unit == "NSA")) {
                    if (pw0 == 1 || pw0 == 2  || pw0 == 3 || pw0 == 5 || pw0 == 6 && pw000 % 3 == 0 || pw000 % 2 !=0 && pw0 == 7 || pw00 == 7 || pw000 == 7 || pw0000 == 7 || pw00000 == 7 || pw000000 == 7) {

                                Console.WriteLine("True");

                             }
                        else {

                                Console.WriteLine("False");

                                }
                }
            }
        }
    }
}
