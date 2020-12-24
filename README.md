# OS_Lab6

Profiling and making a better vesion of the simple program.

 ## Common setup

 Clone the repo and install the dependencies.

 ```bash
 git clone https://github.com/irazozulya/OS_Lab6
 ```

 ## Installation

 Use Visual Studio to compile and start the project.
 

 ## Usage

 The project represents profiling and finding the better version of the simple program.
 
 
 ## Modifications

At the begining the program has this code:<br />
using System;
using System.Threading;

namespace OS_Lab6
{
    class MainClass
    {
        void New_func1() { }

        public static int ResultOfSum(int a, int b)
        {
            return a + b;
        }

        public static int Func1(int a, int b)
        {
            int res = 0;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1);
                if (i > 8)
                    res = ResultOfSum(a, b);
                if (res > 0)
                    return res;
            }
            return res;
        }

        public static int Func2(int a, int b, int c)
        {
            int res = 0;

            for (int i = 0; i < 10; i++)
            {
                b--;
                if (c > b)
                {
                    res = Func1(a, b);
                }
                else
                {
                    res = Func1(a, c);
                }
                if (res > 0)
                    return res;
            }

            return res;
        }

        public static void Main(string[] args)
        {
            Func2(51, 110, 12);
        }
    }
}<br />
The results of the first profiling:<br />
 ![The first picture](https://github.com/irazozulya/OS_Lab6/blob/main/1.png)
 <br />I have deleted the ResultOfSum(int a, int b) function and simplified the Func1(int a, int b) function, so this is the result of the second profiling:<br />
 ![The second picture](https://github.com/irazozulya/OS_Lab6/blob/main/2.png)
 


 ## Functions
 
 Main(string[] args) is used for starting the program<br />

 ## Version

 OS_Lab6 Version 1.0 24/12/2020
 

 ## Author

 - **Iryna Zozulia** - [irazozulya](https://github.com/irazozulya)


 ## Architecture

 Program.cs - the main class file;

 ## License

 [MIT license](https://choosealicense.com/licenses/mit/)

