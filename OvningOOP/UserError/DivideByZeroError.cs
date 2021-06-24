namespace OvningOOP
{
    internal class DivideByZeroError:UserError
    {
        
        public override string UEMessage()
        {
            return "Value cannont be divided by zero.";
        }
    }
}