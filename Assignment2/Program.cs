using HRLib;
namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{

                ConfirmEmployee CE1 = new ConfirmEmployee();
                Console.WriteLine(CE1);

                ConfirmEmployee CE2 = new ConfirmEmployee("software engineer", 40000, "Ankita", "tkg");
                Console.WriteLine(CE2);

                Trainee t1 = new Trainee();
                Console.WriteLine(t1);

            }
            catch (ExceptionOfSalary ex)
			{
                Console.WriteLine(ex.Message);			
            }
        }
    }
}
