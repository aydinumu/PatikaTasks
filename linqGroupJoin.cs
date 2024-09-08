// NOTE: This project does not include a separate README file.

// Task: Create a school database and perform a group join operation on the following two tables:
//       Students Table
//       - StudentId: Unique identifier for the student
//       - StudentName: Student's name
//       - ClassId: Class identifier that the student belongs to
//
//       Classes Table
//       - ClassId: Unique identifier for the class
//       - ClassName: Class name
//
//   Tasks:
//   1. Define the Student and Class classes.
//   2. Create sample data for the Students and Classes collections.
//   3. Perform a group join operation on the Students and Classes tables based on the ClassId.
//   4. Print the results, including the class name and the names of the students in each class.

namespace ConsoleApp1
{
    public class Program
    {
        public class Ogrenci
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public int ClassId { get; set; }
        }

        public class Sinif
        {
            public int ClassId { get; set; }
            public string ClassName { get; set; }
        }

        private static void Main(string[] args)
        {
            List<Sinif> siniflar = new List<Sinif>();
            siniflar.Add(new Sinif { ClassId = 1, ClassName = "Algebra" });
            siniflar.Add(new Sinif { ClassId = 2, ClassName = "Turkish" });
            siniflar.Add(new Sinif { ClassId = 3, ClassName = "Chemistry" });
          
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(new Ogrenci { StudentId = 1, StudentName = "Ali", ClassId = 1 });
            ogrenciler.Add(new Ogrenci { StudentId = 2, StudentName = "Ayşe", ClassId = 2 });
            ogrenciler.Add(new Ogrenci { StudentId = 3, StudentName = "Mehmet", ClassId = 1 });
            ogrenciler.Add(new Ogrenci { StudentId = 4, StudentName = "Fatma", ClassId = 3 });
            ogrenciler.Add(new Ogrenci { StudentId = 5, StudentName = "Ahmet", ClassId = 2 });

            var studentWithClasses = siniflar.GroupJoin(  ogrenciler,
                                                          sinif => sinif.ClassId,
                                                          ogrenci => ogrenci.ClassId,
                                                          (sinif, ogrencilerGrubu) => new
                                                          {
                                                              SinifIsmi = sinif.ClassName,
                                                              Ogrenciler = ogrencilerGrubu.Select(ogrenci => ogrenci.StudentName)
                                                          }
                                                          );
          
            foreach (var item in studentWithClasses)
            {
                Console.WriteLine($"\n---\nSınıf İsmi : {item.SinifIsmi}");
                Console.Write("Öğrenciler : ");
                foreach (var ogrenci in item.Ogrenciler) { Console.Write(ogrenci + " "); }
            }
        }
    }
}
