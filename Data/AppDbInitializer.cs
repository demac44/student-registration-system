using university.Models;

namespace university.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if(!context.Departments.Any())
                {
                    context.Departments.AddRange(new List<Department>()
                    {
                        new Department()
                        {
                            Name = "Computer science and Technology",
                        },
                        new Department()
                        {
                            Name = "Economics",
                        },
                        new Department()
                        {
                            Name = "Engineering",
                        },                        
                        new Department()
                        {
                            Name = "Science",
                        },                        
                        new Department()
                        {
                            Name = "Law",
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Majors.Any())
                {
                    context.Majors.AddRange(new List<Major>()
                    {
                        new Major()
                        {
                            Name = "Software Engineering",
                            Description = "Software Engineering Major",
                            TotalHours = 132,
                            DepartmentId = 1
                        },
                        new Major()
                        {
                            Name = "Cyber Security",
                            Description = "Cyber Security Major",
                            TotalHours = 132,
                            DepartmentId = 1
                        },
                        new Major()
                        {
                            Name = "Business Managment",
                            Description = "Business Managment Major",
                            TotalHours = 132,
                            DepartmentId = 2
                        },
                        new Major()
                        {
                            Name = "Accounting",
                            Description = "Accounting Major",
                            TotalHours = 132,
                            DepartmentId = 2
                        },
                        new Major()
                        {
                            Name = "Law Science",
                            Description = "Law Science Major",
                            TotalHours = 121,
                            DepartmentId = 5
                        },
                        new Major()
                        {
                            Name = "Civil Engineering",
                            Description = "Civil Engineering Major",
                            TotalHours = 132,
                            DepartmentId = 3
                        },
                        new Major()
                        {
                            Name = "Mechanical Engineering",
                            Description = "Mechanical Engineering Major",
                            TotalHours = 132,
                            DepartmentId = 3
                        },
                        new Major()
                        {
                            Name = "Biology",
                            Description = "Biology Major",
                            TotalHours = 121,
                            DepartmentId = 4
                        },
                        new Major()
                        {
                            Name = "Chemistry",
                            Description = "Chemistry Major",
                            TotalHours = 121,
                            DepartmentId = 4
                        }

                    });
                    context.SaveChanges();
                }

                if (!context.Courses.Any())
                {
                    context.Courses.AddRange(new List<Course>()
                    {
                        new Course()
                        {
                            Name = "Introduction to Programming",
                            Description = "Introduction to Programming Course in C++",
                            CreditHours = 3,
                            MajorId = 1
                        },
                        new Course()
                        {
                            Name = "Data Structures",
                            Description = "Data Structures Course",
                            CreditHours = 3,
                            MajorId = 1
                        },
                        new Course()
                        {
                            Name = "Introduction to Cyber Security",
                            Description = "Introduction to Cyber Security Course",
                            CreditHours = 3,
                            MajorId = 2
                        },
                        new Course()
                        {
                            Name = "Data Structures",
                            Description = "Data Structures Course",
                            CreditHours = 3,
                            MajorId = 2
                        },
                        new Course()
                        {
                            Name = "Managment",
                            Description = "Managment Course",
                            CreditHours = 3,
                            MajorId = 3
                        },
                        new Course()
                        {
                            Name = "Calculus I",
                            Description = "Calculus I Course",
                            CreditHours = 3,
                            MajorId = 3
                        },
                        new Course()
                        {
                            Name = "Accounting",
                            Description = "Accounting Course",
                            CreditHours = 3,
                            MajorId = 4
                        },
                        new Course()
                        {
                            Name = "Calculus I",
                            Description = "Calculus I Course",
                            CreditHours = 3,
                            MajorId = 4
                        },
                        new Course()
                        {
                            Name = "Introduction to Law",
                            Description = "Introduction to Law Course",
                            CreditHours = 3,
                            MajorId = 5
                        },
                        new Course()
                        {
                            Name = "Introduction to Civil Engineering",
                            Description = "Introduction to Civil Engineering Course",
                            CreditHours = 3,
                            MajorId = 6
                        },
                        new Course()
                        {
                            Name = "Introduction to Mechanical Engineering",
                            Description = "Introduction to Mechanical Engineering Course",
                            CreditHours = 3,
                            MajorId = 7
                        },
                        new Course()
                        {
                            Name = "Human Anatomy",
                            Description = "Human Anatomy Course",
                            CreditHours = 3,
                            MajorId = 8
                        },
                        new Course(){
                            Name = "Introduction to Chemistry",
                            Description = "Introduction to Chemistry Course",
                            CreditHours = 3,
                            MajorId = 9
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Professors.Any())
                {
                    context.Professors.AddRange(new List<Professor>()
                    {
                        new Professor()
                        {
                            Name = "Ala Abuthawabeh",
                            DepartmentId = 1
                        },
                        new Professor()
                        {
                            Name = "Cristiano Ronaldo",
                            DepartmentId = 2
                        },
                        new Professor()
                        {
                            Name = "John Doe",
                            DepartmentId = 3
                        },
                        new Professor()
                        {
                            Name = "Lionel Messi",
                            DepartmentId = 4
                        },
                        new Professor()
                        {
                            Name = "Tom Hanks",
                            DepartmentId = 5
                        }
                    });
                    context.SaveChanges();
                }

                if(!context.ProfessorCourses.Any())
                {
                    context.ProfessorCourses.AddRange(new List<ProfessorCourse>() 
                    { 
                        new ProfessorCourse() 
                        {
                            CourseId = 2,
                            ProfessorId = 1
                        },
                        new ProfessorCourse()
                        {
                            CourseId = 3,
                            ProfessorId = 1
                        },
                        new ProfessorCourse()
                        {
                            CourseId = 4,
                            ProfessorId = 1
                        },
                        new ProfessorCourse()
                        {
                            CourseId = 5,
                            ProfessorId = 1
                        },
                        new ProfessorCourse()
                        {
                            CourseId = 6,
                            ProfessorId = 2
                        },
                        new ProfessorCourse()
                        {
                            CourseId = 7,
                            ProfessorId = 2
                        },
                        new ProfessorCourse()
                        {
                            CourseId = 8,
                            ProfessorId = 2
                        },
                        new ProfessorCourse()
                        {
                            CourseId = 9,
                            ProfessorId = 2
                        },
                        new ProfessorCourse()
                        {
                            CourseId = 11,
                            ProfessorId = 3
                        },
                        new ProfessorCourse()
                        {
                            CourseId = 12,
                            ProfessorId = 3
                        },
                        new ProfessorCourse()
                        {
                            CourseId = 13,
                            ProfessorId = 4
                        },
                        new ProfessorCourse()
                        {
                            CourseId = 14,
                            ProfessorId = 4
                        },
                        new ProfessorCourse()
                        {
                            CourseId = 10,
                            ProfessorId = 5
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
