class Task68
{

    // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два положительных числа m и n.
    // m = 2, n = 3 -> A(m,n) = 9
    // m = 3, n = 2 -> A(m,n) = 29


    public static string Execute()
    {

        int M = MainClass.ReadInteger("Введите M (положительное)");
        int N = MainClass.ReadInteger("Введите N (положительное)");
        while (M < 0 || N < 0)
        {
            Console.WriteLine("Введенные числа должны быть положительными");
            M = MainClass.ReadInteger("Введите M");
            N = MainClass.ReadInteger("Введите N");
        }

        int result=AkkerMegaMan(M,N);

        return "Результат вычисления функции Аккермана "+result.ToString();

    }

    public static int AkkerMegaMan(int m,int n){
        if(m==0)return n+1;
        if(n==0)return AkkerMegaMan(m-1,1);

        return AkkerMegaMan(m-1,AkkerMegaMan(m,n-1));
    }


}