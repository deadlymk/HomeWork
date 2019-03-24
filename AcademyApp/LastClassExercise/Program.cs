﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace AcademyApp
{
    class Program
    {

        public static void AddStudent(List<Student> allStudents)
        {
            Console.WriteLine("input username");
            string username = Console.ReadLine();
            Console.WriteLine("input lastname");
            string lastName = Console.ReadLine();
            Console.WriteLine("input password");
            int password = int.Parse(Console.ReadLine());
            Student student = new Student(username, lastName, password);

            allStudents.Add(student);
            Console.WriteLine("Gz you create it" + student.FristName + student.LastName);

        }
        public static void AddTrainer(List<Trainer> allTrainers)
        {
            Console.WriteLine("input username");
            string username = Console.ReadLine();
            Console.WriteLine("input lastname");
            string lastName = Console.ReadLine();
            Console.WriteLine("input password");
            int password = int.Parse(Console.ReadLine());

            Trainer trainer = new Trainer(username, lastName, password);
            allTrainers.Add(trainer);
            Console.WriteLine("Gz you create it" + trainer.FristName + trainer.LastName);
        }
        public static void AddAdmin(List<Admin> allAdmins)
        {
            Console.WriteLine("input username");
            string username = Console.ReadLine();
            Console.WriteLine("input lastname");
            string lastName = Console.ReadLine();
            Console.WriteLine("input password");
            int password = int.Parse(Console.ReadLine());

            Admin admin = new Admin(username, lastName, password);
            foreach (var item in allAdmins)
            {
                if (admin.FristName != item.FristName)
                {
                    allAdmins.Add(admin);
                    Console.WriteLine("Gz you create it: " + admin.FristName + admin.LastName);
                    Console.ReadLine();
                }
                else if (admin.FristName == item.FristName && admin.LastName == item.LastName && admin.Password == item.Password)
                {
                    Console.WriteLine("you just wrote the same Account ");
                    break;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }

        static void Main(string[] args)
        {

            Admin stefan = new Admin("Stefan", "Sibinovski", 1111);
            Admin tomas = new Admin("Tomas", "Neznam", 2222);

            List<Admin> allAdmins = new List<Admin> { stefan, tomas };


            Student john = new Student("John", "Doe", 1234);
            Student mario = new Student("Mario", "Simonovski", 1233);
            List<Student> allStudents = new List<Student>() { john, mario };

            Subjects math = new Subjects("Math", 5);
            Subjects art = new Subjects( "Art", 3);
            Subjects biology = new Subjects("Biology", 3);
            Subjects sport = new Subjects("Sport", 3);
            Subjects music = new Subjects("Music", 2);

            List<Subjects> allSubjects = new List<Subjects>() { math, art, biology, sport, music };

            Trainer ivan = new Trainer("Ivan", "Petrovski", 1234);
            Trainer milodrag = new Trainer("Milodrag", "Milkovski", 1233);
            List<Trainer> allTrainers = new List<Trainer>() { ivan, milodrag };

            var JohnStudent = (from student in allStudents
                                where student.FristName == "John"
                                 select student).FirstOrDefault();

            var johnSubjects = (from sub in allSubjects
                                  where sub.SubjectName == "Math" || sub.SubjectName == "Biology"
                                  select sub).ToList();

            JohnStudent.ListOfSubjects = johnSubjects;

            var marioSubjects = (from sub in allSubjects
                                 where sub.SubjectName == "Art" || sub.SubjectName == "Music"
                                 select sub).ToList();


            var marioStudent = (from student in allStudents
                                where student.FristName == "Mario"
                                select student).FirstOrDefault();

            marioStudent.ListOfSubjects = marioSubjects;

            Console.WriteLine("Enter a number ");
            Console.WriteLine(" 1:Admin \n 2:Trainer \n 3:Student");

            var input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("Please login.");
                Console.WriteLine("please enter username");
                var inputUsername = Console.ReadLine();

                Console.WriteLine("please enter password");
                int inputPassword;
                bool inputAdmin2 = Int32.TryParse(Console.ReadLine(), out inputPassword);

                var result = (from admin in allAdmins
                              where admin.FristName == inputUsername && admin.Password == inputPassword
                              select admin).FirstOrDefault();

                Console.WriteLine("Hello " + result.GetFullName());
                Console.WriteLine("1:Add \n 2:Remove");



                int inputAddRemove;
                bool inputAdmin4 = Int32.TryParse(Console.ReadLine(), out inputAddRemove);

                if (inputAddRemove == 1) //add
                {
                    Console.WriteLine("1:Student 2:Trainer 3: Admin! choose 1 to add");
                    var inputPerson = int.Parse(Console.ReadLine());

                    if (inputPerson == 1) //add student
                    {
                        AddStudent(allStudents);


                    }
                    else if (inputPerson == 2) //add trainer
                    {
                        AddTrainer(allTrainers);
                    }
                    else if (inputPerson == 3) //add admin
                    {
                        AddAdmin(allAdmins);

                    }
                    else
                    {
                        Console.WriteLine("pls enter num");
                    }
                }

                else if (inputAddRemove == 2)
                {
                    Console.WriteLine("1:Student 2:Trainer 3:Admin  choose 1 to remove");
                    var inputPersonRemove = int.Parse(Console.ReadLine());
                    if (inputPersonRemove == 1)
                    {
                        foreach (var student in allStudents)
                        {
                            Console.WriteLine(student.FristName);
                        }


                        Console.WriteLine("type the name of the student to delete it ");
                        string inputRemoveStudent = Console.ReadLine();

                        allStudents.RemoveAll(emp => emp.FristName == inputRemoveStudent);
                    }
                    else if (inputPersonRemove == 2)
                    {
                        foreach (var trainer in allTrainers)
                        {
                            Console.WriteLine(trainer.FristName);
                        }
                        Console.WriteLine("type the name of the trainer to delete it ");
                        string inputRemoveTrainer = Console.ReadLine();
                        allTrainers.RemoveAll(emp => emp.FristName == inputRemoveTrainer);

                    }
                    else if (inputPersonRemove == 3) // da nemoze da se remove sam sebe
                    {
                        foreach (var admin in allAdmins)
                        {
                            Console.WriteLine(admin.FristName);

                            if(inputUsername == admin.FristName && inputPassword == admin.Password)
                            {
                                Console.WriteLine("sorry you cant remove your self");
                            }
                            Console.WriteLine();
                        }
                    }

                    else
                    {
                        Console.WriteLine("pls enter number");
                    }
                }

            }
            else if (input == 2)  //Trainer 
            {
                Console.WriteLine("Please login.");
                Console.WriteLine("please enter username");
                var inputTrainerUser = Console.ReadLine();

                Console.WriteLine("please enter password");
                int inputTrainerPassword = int.Parse(Console.ReadLine());

                var trainer = (from trainer1 in allTrainers
                               where trainer1.FristName == inputTrainerUser || trainer1.Password == inputTrainerPassword
                               select trainer1).FirstOrDefault();

                Console.WriteLine("Hello " + trainer.GetFullName());
                Console.WriteLine("1:all students 2:all subjects");

                int inputStudentSubject = int.Parse(Console.ReadLine());
                if (inputStudentSubject == 1)
                {
                    Console.WriteLine("enter a name to get his subjects");
                    foreach (var student in allStudents)
                    {
                        Console.WriteLine(student.FristName);
                    }

                    string inputName = Console.ReadLine();

                    var getStudent = (from student in allStudents
                                      where inputName == student.FristName
                                      select student).FirstOrDefault();
                    getStudent.GetSubjects();
                }
                else if (inputStudentSubject == 2)
                {
                    foreach (var subject in allSubjects)
                    {
                        Console.WriteLine(subject.SubjectName);

                    }
                }
                else if (inputStudentSubject == 2) //Trainer all Subject
                {

                    foreach (var subArray in allSubjects)
                    {
                        Console.WriteLine(subArray.SubjectName);
                        foreach (var item in allStudents)
                        {
                          
                        }
                    }
                }

            }
            else if (input == 3) //student
            {
                Console.WriteLine("Please login.");
                Console.WriteLine("please enter username");
                var inputStudentUser = Console.ReadLine();

                Console.WriteLine("please enter password");
                var inputStudentPw = int.Parse(Console.ReadLine());

                var loginStudent = (from student in allStudents
                                    where student.FristName == inputStudentUser && student.Password == inputStudentPw
                                    select student).FirstOrDefault();
                Console.WriteLine("Hello " + loginStudent.GetFullName());
                
               

            }

            Console.ReadLine();







        }
    }
}
