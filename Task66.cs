class Task66
{

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


    public static string Execute()
    {

        int M= MainClass.ReadInteger("Введите M");
        int N= MainClass.ReadInteger("Введите N");



        string numsBetween=RecurBetween( M>N ? M :N,M<N ? M :N,M>N ? M+1: N+1);
         int numsSumBetween=RecurSumBetween( M>N ? M :N,M<N ? M :N,M>N ? M+1: N+1);




        return "Сумма элементов в промежутке "+ numsSumBetween.ToString();
     
    }

   public static string RecurBetween(int MaxN,int MinN,int iter){
            iter--;
            if(iter==MinN)return MinN.ToString();
            return iter+", "+RecurBetween(MaxN,MinN,iter);
    }

      public static int  RecurSumBetween(int MaxN,int MinN,int iter){
            iter--;
            if(iter==MinN)return MinN;
            return iter+RecurSumBetween(MaxN,MinN,iter);
    }

}