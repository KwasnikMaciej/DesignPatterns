namespace Decorator
{
    public abstract class Beverage
    {
        private string Description;

        public void SetDescription(string description)
        {
            this.Description = description;
        }

        public string GetDescription()
        {
            return Description;
        }

        public abstract decimal GetCost(); 
    }
}
