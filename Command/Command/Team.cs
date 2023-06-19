namespace Command
{
    internal class Team
    {
        public string Name { get; private set; }
        public Team(string name)
        {
            Name = name;
        }

        public void CompleteProject(List<Requirement> requirements)
        {
            foreach(Requirement requirement in requirements)
            {
                Console.WriteLine($"User Story: ({requirement.Description}) has been completed");
            }
        }
    }
}
