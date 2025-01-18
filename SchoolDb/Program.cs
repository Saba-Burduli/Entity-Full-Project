using SchoolDb.Models;
using SchoolDb;
using SchoolDb.Enums;
using SchoolSystemDemo.Models;
using System.Linq;

// სტატიკური მონაცემების List-ების დეკლარაცია:
var roles = new List<Role>();
var classes = new List<Class>();
var grades = new List<Grade>();
var attendanceStatuses = new List<AttendanceStatus>();

// დინამიური მონაცემების List-ები დეკლარაცია:
var pupils = new List<Pupil>();
var teachers = new List<Teacher>();
var journals = new List<Journal>();
var subjects = new List<Subject>();

// სტატიკური მონაცემების წამოღება მონაცემთა ბაზიდან:
using (var context = new SchoolDbContext())
{
    roles = context?.Roles?.ToList();
    classes = context?.Classes?.ToList();
    grades = context?.Grades?.ToList();
    attendanceStatuses = context?.AttendanceStatuses?.ToList();
    subjects = context?.Subjects?.ToList();
}

// მონაცემთა ბაზაში Pupils ცხრილში დინამიური მონაცემების დამატება:
using (var context = new SchoolDbContext())
{

    var pupilList = new List<Pupil>
    {
        new Pupil
        {
            FirstName = "First Name 1",
            LastName = "Last Name 1",
            DoB = new DateTime(2010, 10, 01),
            Gender = Convert.ToBoolean(Gender.Male),
            Address = "Some Address 1",
            ClassId = classes.FirstOrDefault(c => c.ClassName == ClassEnum.EightClass.ToString())?.ClassId
        },

        new Pupil
        {
            FirstName = "First Name 2",
            LastName = "Last Name 2",
            DoB = new DateTime(2011, 11, 01),
            Gender = Convert.ToBoolean(Gender.Female),
            Address = "Some Address 2",
            ClassId = classes.FirstOrDefault(
                c => c.ClassName == ClassEnum.EightClass.ToString())?.ClassId
        },

        new Pupil
        {
            FirstName = "First Name 3",
            LastName = "Last Name 3",
            DoB = new DateTime(2013, 01, 01),
            Gender = Convert.ToBoolean(Gender.Female),
            Address = "Some Address 3",
            ClassId = classes.FirstOrDefault(
                c => c.ClassName == ClassEnum.NinthClass.ToString())?.ClassId
        },

        new Pupil
        {
            FirstName = "First Name 4",
            LastName = "Last Name 4",
            DoB = new DateTime(2014, 11, 01),
            Gender = Convert.ToBoolean(Gender.Male),
            Address = "Some Address 4",
            ClassId = classes.FirstOrDefault(
                c => c.ClassName == ClassEnum.NinthClass.ToString())?.ClassId
        },

        new Pupil
        {
            FirstName = "First Name 5",
            LastName = "Last Name 5",
            DoB = new DateTime(2015, 11, 01),
            Gender = Convert.ToBoolean(Gender.Female),
            Address = "Some Address 5",
            ClassId = classes.FirstOrDefault(
                c => c.ClassName == ClassEnum.EleventhClass.ToString())?.ClassId
        },

        new Pupil
        {
            FirstName = "First Name 6",
            LastName = "Last Name 6",
            DoB = new DateTime(2016, 11, 01),
            Gender = Convert.ToBoolean(Gender.Female),
            Address = "Some Address 6",
            ClassId = classes.FirstOrDefault(
                c => c.ClassName == ClassEnum.EleventhClass.ToString())?.ClassId
        },

        new Pupil
        {
            FirstName = "First Name 7",
            LastName = "Last Name 7",
            DoB = new DateTime(2017, 11, 01),
            Gender = Convert.ToBoolean(Gender.Female),
            Address = "Some Address 7",
            ClassId = classes.FirstOrDefault(
                c => c.ClassName == ClassEnum.TwelvethClass.ToString())?.ClassId
        }
    };

    //foreach (var pupil in pupilList)
    //{
    //    context?.Pupils?.Add(pupil);
    //}

    //context?.SaveChanges();
    //Console.WriteLine("Pupil List added successfully!");
};

// მონაცემთა ბაზის Pupils ცხრილიდან მონაცემების წამოღება & დაბეჭვდა კონსოლში:
using (var context = new SchoolDbContext())
{
    try
    {
        var annonymousPupils = (from p in context.Pupils
                                join c in context.Classes
                                on p.ClassId equals c.ClassId
                                select new
                                {
                                    p.FirstName,
                                    p.LastName,
                                    p.Address,
                                    p.Gender,
                                    p.DoB,
                                    c.ClassName
                                }).ToList();

        Console.WriteLine("-------- Pupil List ----------\n");

        foreach (var pupil in annonymousPupils)
        {
            try
            {
                Console.WriteLine($"First Name: {pupil.FirstName}\n" +
                    $"Last Name: {pupil.LastName}\n" +
                    $"DoB: {pupil.DoB}\n" +
                    $"Gender: {(Gender)(Convert.ToInt32(pupil.Gender))}\n" +
                    $"Address: {pupil.Address}\n" +
                    $"Class: {pupil.ClassName}");

                Console.WriteLine("---------------------------------");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error displaying pupil data: {ex.Message}");
            }
        }
    }

    catch (Exception ex) 
    {
        Console.WriteLine($"Error retrieving data: {ex.Message}");
    }    
}

// მონაცემთა ბაზის Pupils ცხრილში კონკრეტული ჩანაწერის რედაქტირება:
using (var context = new SchoolDbContext())
{
    try
    {
        var pupilToUpdate = context?.Pupils?
                            .FirstOrDefault(p => p.FirstName == "First Name 1" && p.LastName == "Last Name 1");


        if (pupilToUpdate != null)
        {
            pupilToUpdate.FirstName = "Nikoloz";
            pupilToUpdate.LastName = "Varamashvili";

            try
            {
                var classToUpdate = classes?.FirstOrDefault(c => c.ClassName == ClassEnum.NinthClass.ToString());
                if (classToUpdate != null)
                {
                    pupilToUpdate.ClassId = classToUpdate.ClassId;
                }
                else
                {
                    Console.WriteLine("Class not found.");
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving class: {ex.Message}");
                return;
            }

            try
            {
                //context?.Pupils?.Update(pupilToUpdate);
                //context?.SaveChanges();
                //Console.WriteLine("Pupil updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating pupil: {ex.Message}");
            }
        }

        else
        {
            Console.WriteLine("Pupil not found!");
        }
    }

    catch (Exception ex)
    {
        Console.WriteLine($"Error accessing the database: {ex.Message}");
    }
}

// მონაცემთა ბაზის Pupils ცხრილიდან მონაცემების წაშლა:
using (var context = new SchoolDbContext())
{
    try
    {
        var pupilToRemove = context.Pupils?
                            .Where(p => p.FirstName == "First Name 2")
                            .ToList();

        if (pupilToRemove != null)
        {
            try
            {
                context?.RemoveRange(pupilToRemove);
                context?.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error removing pupil: {ex.Message}");
            }
        }

        else
        {
            Console.WriteLine("Pupil not found!");
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error accessing the database: {ex.Message}");
    }

}


// Teacher Table _ CRUD Operations
// მონაცემთა ბაზაში Teachers ცხრილში დინამიური მონაცემების დამატება:
using (var context = new SchoolDbContext())
{

    var teacherList = new List<Teacher>
    {
        new Teacher
        {
            FirstName = "Teacher FirstName 1",
            LastName = "Teacher LastName 1",
            Gender = Convert.ToBoolean(Gender.Male),
            Address = "Some Address 11",
            HireDate = new DateTime(2015,10,1),
            RoleId = 3
        },

        new Teacher
        {
            FirstName = "Teacher FirstName 2",
            LastName = "Teacher LastName 2",
            Gender = Convert.ToBoolean(Gender.Female),
            Address = "Some Address 22",
            HireDate = new DateTime(2015,11,11),
            RoleId = 1
        },

        new Teacher
        {
            FirstName = "Teacher FirstName 3",
            LastName = "Teacher LastName 3",
            Gender = Convert.ToBoolean(Gender.Male),
            Address = "Some Address 33",
            HireDate = new DateTime(2016,10,1),
            RoleId = 2
        },

        new Teacher
        {
            FirstName = "Teacher FirstName 4",
            LastName = "Teacher LastName 4",
            Gender = Convert.ToBoolean(Gender.Female),
            Address = "Some Address 44",
            HireDate = new DateTime(2017,10,1),
            RoleId = 4
        }
    };

    //try
    //{
    //    foreach (var teacher in teacherList)
    //    {
    //        context?.Teachers?.Add(teacher);
    //    }
    //    context?.SaveChanges();
    //    Console.WriteLine("Pupil List added successfully!");
    //}

    //catch (Exception ex)
    //{
    //    Console.WriteLine($"Error in addition of teachers list in DB: {ex.Message}");
    //}
};


// მონაცემთა ბაზის Teachers ცხრილიდან მონაცემების წამოღება & დაბეჭვდა კონსოლში:
using (var context = new SchoolDbContext())
{
    try
    {
        var annonymousTeachers = (from t in context.Teachers
                                join r in context.Roles
                                on t.RoleId equals r.RoleId
                                select new
                                {
                                    t.FirstName,
                                    t.LastName,
                                    t.Address,
                                    t.Gender,
                                    t.HireDate,
                                    r.RoleName
                                }).ToList();

        Console.WriteLine("-------- Teacher List ----------\n");

        foreach (var teacher in annonymousTeachers)
        {
            try
            {
                Console.WriteLine($"First Name: {teacher.FirstName}\n" +
                    $"Last Name: {teacher.LastName}\n" +
                    $"DoB: {teacher.HireDate}\n" +
                    $"Gender: {(Gender)(Convert.ToInt32(teacher.Gender))}\n" +
                    $"Address: {teacher.Address}\n" +
                    $"Class: {teacher.RoleName}");

                Console.WriteLine("---------------------------------");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error displaying teacher data: {ex.Message}");
            }
        }
    }

    catch (Exception ex)
    {
        Console.WriteLine($"Error retrieving data: {ex.Message}");
    }
}

// Subjects Table _ CRUD Operations
// მონაცემთა ბაზაში Subjects ცხრილში დინამიური მონაცემების დამატება:
using (var context = new SchoolDbContext())
{

    var subjectList = new List<Subject>
    {
        new Subject
        {
             SubjectName = "Subject1"
        },
        new Subject
        {
             SubjectName = "Subject2"
        },
        new Subject
        {
             SubjectName = "Subject3"
        },
        new Subject
        {
             SubjectName = "Subject4"
        },
        new Subject
        {
             SubjectName = "Subject5"
        },
        new Subject
        {
             SubjectName = "Subject6"
        },
        new Subject
        {
             SubjectName = "Subject7"
        },
        new Subject
        {
             SubjectName = "Subject8"
        }   
    };

    try
    {
        //foreach (var subject in subjectList)
        //{
        //    context?.Subjects?.Add(subject);
        //}
        //context?.SaveChanges();
        //Console.WriteLine("Subject List added successfully!");
    }

    catch (Exception ex)
    {
        Console.WriteLine($"Error in addition of subjects list in DB: {ex.Message}");
    }
};

// Journals Table _ CRUD Operations
// მონაცემთა ბაზაში Journals ცხრილში დინამიური მონაცემების დამატება:
using (var context = new SchoolDbContext())
{

    var journalList = new List<Journal>
    {
       new Journal
       {
           GradeId = context.Grades.FirstOrDefault(g=>g.GradeName == "A").GradeId,
           PupilId = 2,
           RegistrationDate = DateTime.Now,
           SubjectId = 3,
           TeacherId = 4,
           AttendanceStatusId = 2
       }       
    };

    try
    {
        foreach (var journal in journalList)
        {
            context?.Journals?.Add(journal);
        }
        context?.SaveChanges();
        Console.WriteLine("Journal List added successfully!");
    }

    catch (Exception ex)
    {
        Console.WriteLine($"Error in addition of journals list in DB: {ex.Message}");
    }
};

using (var context = new SchoolDbContext())
{
    // task 1
    var failingPupils = from g in context.Grades
                             join j in context.Journals
                             on g.GradeId equals j.GradeId
                             join p in context.Pupils
                             on j.PupilId equals p.PupilId
                             //join t in teachers
                             //on j.TeacherId equals t.TeacherId
                             //join s in subjects
                             //on j.SubjectId equals s.SubjectId
                             //join a in attendanceStatuses
                             //on j.AttendanceStatusId equals a.AttendanceStatusId
                             //where g.GradeName == "A"
                             select new { p.FirstName, p.LastName, g.GradeName };

    foreach (var pupil in failingPupils)
    {
        Console.WriteLine($"{pupil.FirstName} {pupil.LastName} - Score: {pupil.GradeName}");
    }

}


Console.ReadKey();

