namespace Command
{
    internal class Requirement
    {
        public string Description { get; private set; }

        public Requirement(string title)
        {
            Description = title;
        }
    }
}
