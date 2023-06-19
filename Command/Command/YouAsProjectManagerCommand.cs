namespace Command
{
    internal class YouAsProjectManagerCommand: ICommand
    {
        public YouAsProjectManagerCommand(Team team, List<Requirement> requirements)
        {
            Team = team;
            Requirements = requirements;
        }

        public void Execute()
        {
            Team.CompleteProject(Requirements);
        }

        protected Team Team { get; set; }

        protected List<Requirement> Requirements { get; set; } 
    }
}
