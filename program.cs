using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_assignment
{
    
        class Program
        {

            public static int ValidateMenuSelection()
            {
                string userInput = "";
                bool validMenuSelect = false;

                while (validMenuSelect == false)
                {
                    Console.WriteLine("1=Get Rectangle Length");
                    Console.WriteLine("2=Change Rectangle Length");
                    Console.WriteLine("3=Get Rectangle Width");
                    Console.WriteLine("4=Change Rectangle Width");
                    Console.WriteLine("5=Get Rectangle Perimeter");
                    Console.WriteLine("6=Get Rectangle Area");
                    Console.WriteLine("7=Exit\n");

                    Console.WriteLine("Please select an option, by entering a number:\n");
                    userInput = Console.ReadLine();
                    if (userInput != "1" &&
                        userInput != "2" &&
                        userInput != "3" &&
                        userInput != "4" &&
                        userInput != "5" &&
                        userInput != "6" &&
                        userInput != "7")

                    {
                        Console.WriteLine("That's not a valid option, please try again:\n");
                    }
                    else
                    {
                        validMenuSelect = true;
                    }
                }
                Console.WriteLine();
                return int.Parse(userInput);
            }
            public static int ValidateUserInput(string rectSide)
            {
                int number = 1;
                bool isValid = false;
                while (isValid == false)
                {
                    Console.WriteLine($"Please enter {rectSide} of your rectangle:");
                    string userInput = Console.ReadLine();
                    Console.WriteLine();
                    bool result = int.TryParse(userInput, out number);
                if (result == false)
                {
                    Console.WriteLine("thats not a valid input Please try again.\n");
                }
                else if (number < 0)
                {
                    Console.WriteLine("number cannot be less than 0 please try again.\n");
                }
                else
                {
                    Console.WriteLine($"The {rectSide} of rectangle is now {number}.\n ");
                    isValid = true;

                }

                    
                }
                return number;

            }

            static void Main(string[] args)
            {
                Rectangle r = new Rectangle();

                bool validRectangleSelect = false;
                string rectangleSelection;
                int selection;

                while (validRectangleSelect == false)
                {
                    Console.WriteLine("1 = create default(1 unit * 1 unit) rectangle\n");
                    Console.WriteLine("2 = choose a custom rectangle\n");
                    Console.WriteLine("Choose a menu item to begin:");
                    rectangleSelection = Console.ReadLine();
                    Console.WriteLine();
                    if (rectangleSelection != "1" && rectangleSelection != "2")
                    {
                        Console.WriteLine("That's not a valid selection, please try again.\n");
                    }
                    else if (int.Parse(rectangleSelection) == 1)
                    {
                        validRectangleSelect = true;
                        int length;
                        int width;
                        length = 1;
                        width = 1;
                        Console.WriteLine($"Your length  and width of your rectangle are {length} and {width}.\n");
                        Rectangle customRectangle = new Rectangle(length, width);
                        r = customRectangle;
                    }
                    else if (int.Parse(rectangleSelection) == 2)
                    {
                        validRectangleSelect = true;
                        int length;
                        int width;
                        length = ValidateUserInput("length");
                        width = ValidateUserInput("width");
                        Console.WriteLine($"Your length  and width of your rectangle are  {length}  and {width}.\n");
                        Rectangle customRectangle = new Rectangle(length, width);
                        r = customRectangle;
                    }

                }


                selection = ValidateMenuSelection();

                while (selection != 7)
                {
                    int result;

                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine($"length is: {r.GetLength()}\n");
                            break;
                        case 2:
                            result = ValidateUserInput("length");
                            r.SetLength(result);
                            break;
                        case 3:
                            Console.WriteLine($"Width is: {r.GetWidth()}\n");
                            break;
                        case 4:
                            result = ValidateUserInput("Width");
                            r.SetWidth(result);
                            break;
                        case 5:
                            Console.WriteLine($"The result of {(r.GetLength() * 2)}+ {(r.GetWidth()) * 2} is: {r.GetPerimeter()}\n");
                            break;
                        case 6:
                            Console.WriteLine($"The result of {r.GetLength()} *{r.GetWidth()} is: {r.GetArea()}\n");
                            break;
                    case 7: default:break;
                }

                    selection = ValidateMenuSelection();
                }

            }
        }
    }









