namespace TaskMenuMethods
{
    internal class Program
    {
        static int DisplayMin(List<int> numbers)
        {
            int min;
            min = numbers[0];
            for (int i = 1; i < numbers.Count - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }
                else
                {
                    if (numbers[i + 1] < min)
                    {
                        min = numbers[i + 1];
                    }
                }
            }

            return min;
        }
        static int DisplayMax(List<int> numbers)
        {
            int max;
            max = numbers[0];
            for (int i = 1; i < numbers.Count - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }

                }
                else
                {
                    if (numbers[i + 1] > max)
                    {
                        max = numbers[i + 1];
                    }
                }

            }

            return max;
        }

        static void PrintNumbers(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("The List is Empty");
            }
            else
            {

                Console.Write("[ ");
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write($"{numbers[i]} ");

                }
                Console.WriteLine(" ]");
            }

        }
        static void AddNumber(List<int> numbers)
        {
            int num = 0;
            Console.Write("Please Enter Your Number :");
            num = Convert.ToInt32(Console.ReadLine());
            bool isDuplicate = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (num == numbers[i])
                {
                    Console.WriteLine("Sorry Duplicated Number cannot be added");
                    isDuplicate = true;
                    break;
                }

            }
            if (!isDuplicate)
            {
                Console.WriteLine($"{num} is added");
                numbers.Add(num);
            }

        }

        static double CalcAverage(List<int> numbers)
        {
            double sum = 0;
            double avg = 0;
            if (numbers.Count == 0)
            {
                Console.WriteLine("Unable to calculate average - no data");
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }

                avg = sum / numbers.Count;

            }
            return avg;
        }

        static void ClearList(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("The List is already Empty !");
            }
            else
            {
                Console.WriteLine("The List is cleared Successfully");
                numbers.Clear();
            }
        }

        static int SearchElement(List<int> numbers)
        {
            int searchedNumber = 0;

            Console.Write("Enter The number which you want to search :");
            searchedNumber = Convert.ToInt32(Console.ReadLine());
            bool isFound = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (searchedNumber == numbers[i])
                {
                    Console.WriteLine($"The Number is Found at this {i + 1} index !");
                    isFound = true;
                    return searchedNumber;

                }

            }
            if (!isFound)
            {
                Console.WriteLine("Sorry The number isnot in the list");
            }
            return -1;
        }

        static int LengthList(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("The List is Empty");
            }
            else
            {
                return numbers.Count;
            }
            return -1;
        }

        static void DisplayMenu()
        {
            Console.WriteLine("P-Print Numbers");
            Console.WriteLine("A-Add a number");
            Console.WriteLine("M-Display the mean of the numbers");
            Console.WriteLine("S-Display the smallest Number");
            Console.WriteLine("L-Display the largest number");
            Console.WriteLine("C-Clear the List");
            Console.WriteLine("R-Search for an element");
            Console.WriteLine("V-Lenght of the list");
            Console.WriteLine("Q-Quit");
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            char selection = '\0';
            do
            {
                DisplayMenu();
                selection = Convert.ToChar(Console.ReadLine());
                if (selection == 'P' || selection == 'p')
                {
                    PrintNumbers(numbers);

                }
                else if (selection == 'A' || selection == 'a')
                {

                    AddNumber(numbers);

                }
                else if (selection == 'M' || selection == 'm')
                {
                    double number = CalcAverage(numbers);
                    if (number != 0)
                    {
                        Console.WriteLine("The Average is  : " + number);

                    }
                }
                else if (selection == 'S' || selection == 's')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number - List is Empty");
                    }
                    else
                    {
                        int min = DisplayMin(numbers);
                        Console.WriteLine("The Smallest Number is :" + min);
                    }

                }
                else if (selection == 'L' || selection == 'l')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to find the largest number -List is Empty");
                    }
                    else
                    {
                        int max = DisplayMax(numbers);
                        Console.WriteLine("The Largest Number is :" + max);
                    }

                }
                else if (selection == 'Q' || selection == 'q')
                {
                    Console.WriteLine("GoodBye");

                }
                else if (selection == 'C' || selection == 'c')
                {
                    ClearList(numbers);
                }
                else if (selection == 'R' || selection == 'r')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Sorry The List is Empty");
                    }
                    else
                    {
                        SearchElement(numbers);
                    }
                }
                else if (selection == 'V' || selection == 'v')
                {

                    LengthList(numbers);
                }
                else
                {
                    Console.WriteLine("Invalid Choice Please Try Again");
                }


            } while (selection != 'Q' || selection != 'q');
        }
    }
}
