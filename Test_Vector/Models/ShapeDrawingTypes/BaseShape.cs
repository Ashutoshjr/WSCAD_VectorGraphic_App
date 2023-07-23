namespace Test_Vector.Models
{
    public abstract class BaseShape
    {
        public string Type { get; set; }
        public string Color { get; set; }

        // New property to hold formatted Type value
        public string FormattedType => char.ToUpper(Type[0]) + Type.Substring(1);

    }

}
