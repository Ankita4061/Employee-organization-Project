namespace HRLib
{
    public abstract class Employee
    {
        #region properties and declarations
        private static int count = 0;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        #region Constructors
        public Employee()
        {
            Name = "bhavana Desai";
            Address = "TKG";
            count++;
            Id = count;
        }

        public Employee(string nam, string addres) : this()
        {
            Name = nam;
            Address = addres;
        }

        #endregion

        #region abstract method calculate salary

        public abstract double CalculateSalary();
        #endregion

        public override string ToString()
        {
            return $"{Name} with employee id {Id} is a basic employee with salary {this.CalculateSalary}";
        }
    }
}
