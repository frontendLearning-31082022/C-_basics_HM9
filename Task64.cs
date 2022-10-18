class Task64
{

//   Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


    public static string Execute()
    {

        int N= MainClass.ReadInteger("Введите N");
        string result=RecurAllNnumbers(N+1);

        return result;
     
    }

    public static string RecurAllNnumbers(int N){
            N--;
            if(N==1)return "1";
            return N+", "+RecurAllNnumbers(N);
    }

}