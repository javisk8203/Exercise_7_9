using System;

class digits
{
    static void Main()
    {
        //counters of number of digits "one" is for one digit, "two" is for 2 digits, "three" is for 3 digits and "more" is for more than 3 digits
        int one = 0, two = 0, three = 0, more = 0;

        Console.Write("Insert a number: ");
        
        // read the number as string to check the word "end"
        string end = Console.ReadLine();

        while(end !="end")
        {
            int input = Convert.ToInt32(end);

            if(input != 0)
            {
                if(input/10 == 0)
                    one ++;  // it only has one digit
                else 
                if (input/100 == 0)
                    two ++;  // the number has 2 digits
                    else
                    if (input/1000 == 0)
                    three ++;  // the number has 3 digits
                    else
                    more++;  // the number has more than 3 digits
            }
            end = Console.ReadLine();
        }
        Console.WriteLine("one digit: {0} two digits: {1} three digits: {2} more digits: {3}", one, two, three, more); 
    }
}

