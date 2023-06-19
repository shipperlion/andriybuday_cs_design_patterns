using Mediator;

var brain = new Brain();

try
{
    while (true)
    {
        Console.WriteLine("Enter body part (‘Ear’, ‘Eye’, ‘Hand’, ‘Leg’ or empty to exit):");
        string? stringBodyPart = Console.ReadLine();

        switch (stringBodyPart)
        {
            case "Hand":
                brain.Hand.Changed();
                break;
            case "Eye":
                brain.Eye.Changed();
                break;
            case "Ear":
                brain.Ear.Changed();
                break;
            case "Leg":
                brain.Leg.Changed();
                break;
            default:
                throw new Exception("Unknown body part");
        }
    }
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
