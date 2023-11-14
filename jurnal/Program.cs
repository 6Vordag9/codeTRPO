using System;
using static System.Collections.Specialized.BitVector32;

namespace jurnal
{
    class Program
    {  
         static void addUserJournal(ref string[] copyJournal, int lastUserId)
        {
            
            Student newStudent = new Student();
            Console.WriteLine("Введите имя студента");
            newStudent.firstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию студента");
            newStudent.sureName = Console.ReadLine();
            Console.WriteLine("Введите отчество студента");
            newStudent.lastName = Console.ReadLine();
            copyJournal[lastUserId] = ("     |" + lastUserId + "№"+ " " + newStudent.firstName + " " + newStudent.sureName + " " + newStudent.lastName + "|");

        }



        static void DOBAVLENIE(ref string[] copyJournal, int userId)
        {

            
            Student sudent1 = new Student();
            Console.WriteLine("Введите имя студента");
            sudent1.firstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию студента");
            sudent1.sureName = Console.ReadLine();
            Console.WriteLine("Введите отчество студента");
            sudent1.lastName = Console.ReadLine();
            copyJournal[userId] = ("       |"+ userId + "№" + " " + sudent1.firstName + " " + sudent1.sureName + " " + sudent1.lastName+ "|");
            

        }



        static void ocenkiMasiv(ref string[,] massiv )
        {
            Console.WriteLine("Введите день в который хотите поставить оценку.");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер человека которому хотите поставить ");
            int idPerson = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите оценку");
            massiv[day, idPerson] = "|            "+ Console.ReadLine()+"            |" ;
        }
        static void Main(string[] args)
        {
            int lastUserId;
            string g;
            string[] copyJournal = new string[100];
            string[] osnMassiv = new string[100];
            string[,] ratingsUser = new string[30, 30];
            for (int i = 1; i < 30; i++)
            {
                
                g = Convert.ToString(i);
                ratingsUser[i,0] = g + ".10.2 | "; 

            }
            lastUserId = 1;
            try
            {
                while (true)

                {

                    string selectedAction;

                    Console.WriteLine("Введите нужно вам действие");
                    Console.WriteLine("#1 Добавить нового ученика");
                    Console.WriteLine("№2 Вывести всеь список учеников");
                    Console.WriteLine("№3 Удаление учеников");
                    Console.WriteLine("№4 Удаление учеников");
                    Console.WriteLine("№5 Поставить и удалить оценку");
                    selectedAction = Console.ReadLine();
                    switch (selectedAction)
                    {
                        case "1":
                            addUserJournal(ref copyJournal, lastUserId);
                            Console.WriteLine(copyJournal[lastUserId]);
                            osnMassiv[lastUserId] = copyJournal[lastUserId];
                            lastUserId++;
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "2":
                            for (int i = 0; i < lastUserId; i++)
                            {
                                Console.WriteLine(osnMassiv[i]);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "3":
                            Console.WriteLine("Введите номер пользователя который нужно удалить.");
                            int deletPeaple = Convert.ToInt32(Console.ReadLine());
                            Array.Clear(osnMassiv, deletPeaple, 1);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "4":
                            Console.WriteLine("Введите номер пользователя который нужно заменить.");
                            int zamenaPeaple = Convert.ToInt32(Console.ReadLine());
                            DOBAVLENIE(ref copyJournal, zamenaPeaple);
                            osnMassiv[zamenaPeaple] = copyJournal[zamenaPeaple];
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "5":
                            ocenkiMasiv(ref ratingsUser);
                            for (int i = 0; i < lastUserId; i++)
                            {
                                Console.Write(osnMassiv[i]);
                            }

                            int height = ratingsUser.GetLength(0);
                            int width = ratingsUser.GetLength(1);
                            for (int i = 0; i < ratingsUser.GetLength(0); i++)
                            {
                                for (int j = 0; j < ratingsUser.GetLength(1); j++)
                                {
                                    Console.Write(ratingsUser[i, j]);
                                }
                                Console.WriteLine();
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        default:
                            break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Произошла ошибка, перезапуск программы.");
                Console.ReadKey();
                Console.Clear();

            }



            }

        }


        class Student

        {

            public string firstName;
            public string sureName;
            public string lastName;
     

        }

    }
