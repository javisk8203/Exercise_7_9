using System;

public class Average{
    public static void Main(){

        double sum = 0, note, count = 0, average;
        string mark;

        // we read the mark as string to check the word "end"
        Console.Write("Insert a mark: ");
        mark = Console.ReadLine();

        // if the mark isn't an end then we pass it to double to work with it
        while(mark != "end"){  
            note = Convert.ToDouble(mark);
            count++;   //counter of numbers
            sum += note;  // sum of all the notes
            Console.Write("Insert a mark: ");
            mark = Console.ReadLine();
        }
        if(count!= 0){
            average = sum / count;  //calculate the average
            Console.WriteLine("The average is {0}.",average);
        }
    }
}
