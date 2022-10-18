using System.Text.RegularExpressions;
class OneMore
{

    // Доп задача
    // Заданы 2 массива: info и data. 
    // В массиве data хранятся двоичные представления нескольких чисел (без разделителя). 
    // В массиве info хранится информация о количестве бит, которые занимают числа из массива info. 
    // Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

    // входные данные: data = {0, 1, 1, 1, 1, 0, 0, 0, 1 } info = {2, 3, 3, 1 }выходные данные: 1, 7, 0, 1


    public static string Execute()
    {

        int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
        int[] info = { 2, 3, 3, 1};
        // int[] info = { 2, 3, 3, 1,3,10,12 };

        List<int>result=new List<int>();

        int offset=0;
        for (int i = 0; i <info.Length; i++)
        {
            int countDigits=info[i]; 
            if(offset>=data.Length)offset=offset-(offset/data.Length)*data.Length;
           string bin=  RecurGenBinary(offset-1,offset-1+countDigits,data);
            offset=offset+countDigits;
           
           result.Add( Convert.ToInt32(bin, 2)); 
        }

        string msgResult="";
        result.ForEach(x=>msgResult=msgResult+x.ToString()+", ");
        msgResult = Regex.Replace(msgResult, @", $", "");
        int[] resultArray=  result.ToArray();

        return "Получившийся десятичный массив "+ msgResult;

    }


    public static string RecurGenBinary(int iter,int endPos,int[] array){
        iter++;
        
        int iterAtArray=iter;
        if(iterAtArray>=array.Length)iterAtArray=iterAtArray-(iterAtArray/array.Length)*array.Length;

        if(iter==endPos)return array[iterAtArray].ToString();
        return array[iterAtArray]+ RecurGenBinary(iter,endPos,array);

    }

}