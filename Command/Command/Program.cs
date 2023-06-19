using Command;

var customer = new Customer();

var team = new Team("Z");
var requirements = new List<Requirement>() { new Requirement("Cool web site"), new Requirement("Ability to book beer on site") };

ICommand commandX = new YouAsProjectManagerCommand(team, requirements);
customer.AddCommand(commandX);

var heroDeveloper = new HeroDeveloper();
ICommand commandA = new HeroDeveloperCommand(heroDeveloper, "A");
customer.AddCommand(commandA);

customer.SignContractWithBoss();
