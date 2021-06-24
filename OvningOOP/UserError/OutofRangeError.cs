namespace OvningOOP
{
    internal class OutofRangeError:UserError
    {
        

        public override string UEMessage()
        {
            return "The value inputted is out of valid range. this fired in Error!";
        }
    }
}