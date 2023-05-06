using Proxy;
using System.Security.Cryptography;
using System.Text;

int opNum = 0;
try
{
    var proxy = new RobotBombDefuserProxy(42);
    proxy.WalkStraightForward(100);
    opNum++;
    proxy.TurnRight();
    opNum++;
    proxy.WalkStraightForward(5);
    opNum++;
    proxy.DefuseBomb();
    opNum++;
    Console.WriteLine();
}
catch (Exception e)
{
    Console.WriteLine($"Exception has been caught with message: ({e.Message}). Decided to have human operate robot there.");
   
    PlanB(opNum);
}

static void PlanB(int nextOperationNum)
{
    RobotBombDefuser humanOperatingRobotDirectly = new RobotBombDefuser();
    if (nextOperationNum == 0)
    {
        humanOperatingRobotDirectly.WalkStraightForward(100);
        nextOperationNum++;
    }
    if (nextOperationNum == 1)
    {
        humanOperatingRobotDirectly.TurnRight();
        nextOperationNum++;
    }
    if (nextOperationNum == 2)
    {
        humanOperatingRobotDirectly.WalkStraightForward(5);
        nextOperationNum++;
    }
    if (nextOperationNum == 3)
    {
        humanOperatingRobotDirectly.DefuseBomb();
    }
}
