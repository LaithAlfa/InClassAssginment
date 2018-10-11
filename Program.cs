using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace InClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {

                    //no matter what, delete and then create
                    //db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    if(!db.Students.Any())
                    {
                        List<Student> students = new List<Student>()
                        {
                            new Student()
                            {
                                FirstName = "Laith",
                                LastName = "Alfaloujeh",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Freshman"
                            },
                            new Student()
                            {
                                FirstName = "Mekkala",
                                LastName = "Bourape",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Charles",
                                LastName = "Coufal",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Junior"
                            },
                            new Student()
                            {
                                FirstName = "John",
                                LastName = "Cunningham",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Michael",
                                LastName = "Hayes",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Freshman"
                            },
                            new Student()
                            {
                                FirstName = "Aaron",
                                LastName = "Hebert",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Yi Fu",
                                LastName = "Ji",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Junior"
                            },
                            new Student()
                            {
                                FirstName = "Todd",
                                LastName = "Kile",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Mara",
                                LastName = "Kinoff",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Freshman"
                            },
                            new Student()
                            {
                                FirstName = "Cesareo",
                                LastName = "Lona",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Michael",
                                LastName = "Matthews",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Junior"
                            },
                            new Student()
                            {
                                FirstName = "Mason",
                                LastName = "McCollum",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Alexander",
                                LastName = "McDonald",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Freshman"
                            },
                            new Student()
                            {
                                FirstName = "Phelps",
                                LastName = "Merrell",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Quan",
                                LastName = "Nguyen",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Junior"
                            },
                            new Student()
                            {
                                FirstName = "Alexander",
                                LastName = "Roder",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Amy",
                                LastName = "Saysourinyosack",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Freshman"
                            },
                            new Student()
                            {
                                FirstName = "Claudia",
                                LastName = "Silva",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Gabriela",
                                LastName = "Valenzuela",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Junior"
                            },
                            new Student()
                            {
                                FirstName = "Kayla",
                                LastName = "Washington",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Matthew",
                                LastName = "Webb",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Freshman"
                            },
                            new Student()
                            {
                                FirstName = "Cory",
                                LastName = "Williams",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Sophomore"
                            },
                                            
                        };

                        db.Students.AddRange(students);  

                        db.SaveChanges();                                              

                    }
                    else
                    {

                   // Where Practice

                    // 1) Connect to the database and show all records in the Students table

                    var students = db.Students.ToList();

                    Console.WriteLine("ALL RECORDS IN THE STUDENTS TABLE");
                    foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
                    Console.WriteLine();

                    // 2) Connect to the database and show all records of students who are not seniors

                    var studentNotSenior = db.Students.Where(s => s.Role != "Senior");

                    Console.WriteLine("STUDENTS WHO ARE NOT SENIORS");
                    foreach(Student s in studentNotSenior)
                        {
                            Console.WriteLine(s);
                        }
                    Console.WriteLine("");

                    // 3) Connect to the database and show all students whose first names begin with letters 'M' or lower

                    Console.WriteLine("FIRST NAME BEGINS WITH 'M'");

                    var studentFirstLetterM = from s in db.Students
                                                where s.FirstName.StartsWith("M")
                                                select s;

                    foreach(Student s in studentFirstLetterM){
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");
                    

                    // 1) Connect to the database and find a student named "John" and print that record to the screen
                    Console.WriteLine("FIRST NAME BEGINS WITH 'JOHN'");
                    var studentNameJohn = db.Students.Where(s => s.FirstName == "John");;
                    foreach(Student s in studentNameJohn){
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");


                    // 2) Connect to the database and find a student named "Alexander" and print that record to the screen
                     Console.WriteLine("FIRST NAME BEGINS WITH 'ALEXANDER'");
                    var studentNameAlexander = from s in db.Students
                                                where s.FirstName == ("Alexander")
                                                select s;
                    foreach(Student s in studentNameAlexander){
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");

                    

                    // 3) Connect to the database and find a student who has the shortest first name and print that record to the screen
                     Console.WriteLine("FIRST SHORTEST NAME");
                    var studentShortName = from s in db.Students
                                       orderby s.LastName.Length
                                       select s;
                    foreach(Student s in studentShortName){
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");
                    
                    
                    
                    // 4) Connect to the database and find a student who has the shortest last name and print that record to the screen
                      Console.WriteLine("last SHORTEST NAME");
                    var studentShortLastName = from s in db.Students
                                       orderby s.LastName.Length
                                       select s ;
                                        foreach(Student s in studentShortLastName){
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");
                    

                    // 5)  Connect to the database and find a student who has the shortest last name but also has the longest first name and print that record to the screen

                       Console.WriteLine("last SHORTEST NAME");
                    var studentShortBothName = from s in db.Students
                                       orderby s.LastName.Length ascending
                                        orderby s.FirstName.Length descending 
                                        select s;
                                        foreach(Student s in studentShortBothName){
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");


                    // Sort Practice

                    // 1) Connect to the database and show all students sorted by first name
                     Console.WriteLine("show all students sorted by first name");
                    var studentSortFirstName = from s in db.Students
                                                 orderby s.FirstName  
                                                select s;
                    foreach(Student s in studentSortFirstName){
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");

                    // 2) Connect to the database and show all students sorted by last name descending
                      Console.WriteLine("show all students sorted by last name");
                    var studentSortLastName = from s in db.Students
                                                 orderby s.LastName  
                                                select s;
                    foreach(Student s in studentSortLastName){
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");

                    // 3) Connect to the database and show all students sorted by rank (Freshman, Sophomore, Junior, Senior, Graduate Student)
                        Console.WriteLine("show all students sorted by rank (Freshman, Sophomore, Junior, Senior, Graduate Student)");
                    var studentSortByRank = from s in db.Students
                                                 orderby s.Role 
                                                select s;
                    foreach(Student s in studentSortByRank){
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");
                   
                   
                   // 4)  Connect to the database and show students who are Seniors and sorted by last name

                    Console.WriteLine("SENIORS SORTED BY LAST NAME");

                    var seniorLast = db.Students
                                        .Where(s => s.Role == "Senior")
                                        .OrderBy(s => s.LastName);
                    
                    foreach(Student s in seniorLast){
                        Console.WriteLine(s);
                    }

                    Console.WriteLine("");

                    // 5) Connect to the database and show students who are NOT Seniors and sorted by first name descending
                         Console.WriteLine("students who are NOT Seniors and sorted by first name descending");
                         var notSenior = db.Students 
                                        .Where(s => s.Role != "senior")
                                        .OrderByDescending(s => s.FirstName);

                    foreach(Student s in notSenior){
                        Console.WriteLine(s);
                    }

                    Console.WriteLine("");
                  
                  
                  
                    // Group Practice

                    // 1) Connect to the database and show all students Grouped by class rank

                      Console.WriteLine(" Grouped by class rank");

                    var studentsGroupRank = db.Students.GroupBy(s => s.Role);

                    foreach(var roleGroup in studentsGroupRank){
                            Console.WriteLine($"Rank: {roleGroup.Key}");
                            foreach(Student s in roleGroup){
                                Console.WriteLine(s);
                            }
                        }
                    
                    Console.WriteLine("");

                    // 2) Connect to the database and show all students Grouped by class rank and sorted by last name

                    Console.WriteLine("all students Grouped by class rank and sorted by last name");

                    var groupRankSortLast = db.Students.OrderBy(t => t.LastName).GroupBy(s => s.Role);

                    foreach(Student s in groupRankSortLast){
                        Console.WriteLine(s);
                    }

                    Console.WriteLine("");

                    // 3) Connect to the database and show all students Grouped by the first letter of their last name and sorted by first name

                    Console.WriteLine("all students Grouped by the first letter of their last name and sorted by first name");

                    var firstLetterLast = db.Students
                                            .OrderBy(c => c.FirstName)
                                            .GroupBy(c => string.IsNullOrEmpty(c.LastName) ? ' ' : c.LastName[0]);
                    
                    foreach (Student c in firstLetterLast){
                        Console.Write(c);
                    }

                    Console.WriteLine("");
                
                    }
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
    }
}