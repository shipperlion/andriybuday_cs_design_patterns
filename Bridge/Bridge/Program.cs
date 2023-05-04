using Bridge;

var brickWallCreator = new BrickWallCreator();
var conctreteSlabWallCreator = new ConcreteSlabWallCreator();

var buildingCompany = new BuildingCompany();
buildingCompany.BuildFoundation();

buildingCompany.WallCreator = conctreteSlabWallCreator;
buildingCompany.BuildRoom();

buildingCompany.WallCreator = brickWallCreator;
buildingCompany.BuildRoom();

buildingCompany.BuildRoom();
buildingCompany.BuildRoof();


