using Adapter;

var electricitySystem = new NewElectricitySystem();
ElectricityConsumer.ChargeNotebook(electricitySystem);

var oldElectricitySystem = new OldElectricitySystem();
var adapter = new AdapterDemo(oldElectricitySystem);
ElectricityConsumer.ChargeNotebook(adapter);
