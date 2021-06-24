namespace OvningOOP
{
    internal class NullInputError:UserError
    {
        
        public override string UEMessage()
        {
            return "You must type some value. value cannot be null";
        }
    }
}