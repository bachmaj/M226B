namespace PolymorphieInterfaces
{
    public class SalesManager : Employee
    {
        private Customer _currentCustomer;

        public string SalesArea { get; set; }

        public SalesManager()
        {

        }

        public bool IsFree()
        {
            return false;
        }

        public void SetCustomer()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
