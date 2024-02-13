using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
          {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir","Evgeniy"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        /// <summary>Метод для преобразования массива классов в общий список</summary>
        /// <param name="classes">Массив классов</param>
        /// <returns>Возврат массива строк с учениками</returns>
        static string[] GetAllStudents(Classroom[] classes)
        {
            if (classes == null)
                throw new ArgumentNullException("Список не может быть пустым");


            //var uinted1 = classes.SelectMany(a => a.Students).ToArray();           

            var united2 = (from a in classes
                          from b in a.Students
                          select b).ToArray();

            return united2;

        }
    }
}