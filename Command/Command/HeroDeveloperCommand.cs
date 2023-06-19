namespace Command
{
    internal class HeroDeveloperCommand : ICommand
    {
        public HeroDeveloperCommand(HeroDeveloper heroDeveloper, string projectName)
        {
            HeroDeveloper = heroDeveloper;
            ProjectName = projectName; 
        }

        public void Execute()
        {
            HeroDeveloper.DoAllHardWork(ProjectName);
        }

        public string ProjectName { get; set; }

        protected HeroDeveloper HeroDeveloper { get; set; }
    }
}
