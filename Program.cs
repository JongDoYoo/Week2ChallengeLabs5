namespace Week2ChallengeLabs5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            
            student.StudentId = "1";
            student.NameOfStudent = "JongDo";
            //student.PhysicsScore = 70;
            //student.ChemistryScore = 80;
            //student.CompSciScore = 90;
            Console.WriteLine("Student I.D is: " + student.StudentId);
            Console.WriteLine("The student name is: " +student.NameOfStudent);
            Console.WriteLine("The physics score is: " + student.PhysicsScore);
            Console.WriteLine("The chemistry score is: " + student.ChemistryScore);
            Console.WriteLine("The computer science score is: " + student.CompSciScore);



        }
        
    }




    public class Student 
    {
        public string StudentId  { get; set; }
        public string NameOfStudent { get; set; }
        public int PhysicsScore { get; set; }
        public int ChemistryScore { get; set; }
        public int CompSciScore { get; set; }

    }
    
}
