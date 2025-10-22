internal class GET
{
    private int _horsePower;
    public int HorsePower
    {
        get
        {
            return _horsePower;
        }
        set
        {
            if (value < 100)
            {
                System.Console.WriteLine("please set correct power");
                return;
            }
            _horsePower = value;
        }
    }
}
