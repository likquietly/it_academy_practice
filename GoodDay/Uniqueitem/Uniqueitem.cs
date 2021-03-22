namespace Uniqueitem
{
    class Uniqueitem
    {
        public static int Id { get; private set; }

        public Uniqueitem()
        {
            Id++;
        }

        public Uniqueitem(int newId)
        {
            Id = newId;
            Id++;
        }
    }
}