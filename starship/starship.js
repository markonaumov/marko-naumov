class Starships {
    constructor({name,pilot,fuelTankCapacity,currentLocation,typeOfStarShip}) {
        this.name=name
        this.pilot=pilot;
        this.fuelTankCapacity=fuelTankCapacity;
        this.currentLocation=currentLocation;
        this.typeOfStarShip=typeOfStarShip;
        
    }
    startEngines() {
            
    }
    takeOff(){

    }
    land(){

    }
}

class Fighter extends Starships {
    constructor(name,pilot,fuelTankCapacity,currentLocation,typeOfStarShip,weapons,shield,numberOfKills){
        super(name,pilot,fuelTankCapacity,currentLocation,typeOfStarShip)
        this.weapons=weapons;
        this.shield=shield;
        this.numberOfKills=numberOfKills;
    }
    shootWeapon1(){
        
    }
}

class CargoShip extends Starships{
    constructor(name,pilot,fuelTankCapacity,currentLocation,typeOfStarShip,cargoCapacity,traidingRoute,loadingCranes){
        super(name,pilot,fuelTankCapacity,currentLocation,typeOfStarShip);
        this.cargoCapacity=cargoCapacity;
        this.traidingRoute=traidingRoute;
        this.loadingCranes=loadingCranes;
    }
    load(){

    }
    unload(){

    }
}

class MiningShip extends Starships{
    constructor(name,pilot,fuelTankCapacity,currentLocation,typeOfStarShip,miningTools,miningTypes,miningStorageCapacity){
        super(name,pilot,fuelTankCapacity,currentLocation,typeOfStarShip);
        this.miningTools=miningTools;
        this.miningTypes=miningTypes;
        this.miningStorageCapacity=miningStorageCapacity;

    }
    mine(){

    }
    setStorageTemperature(){

    }
}

let fighter1 = new Fighter("El","Luke",100,"Macedonia","Fighter","Canon",100,578);
let cargo1 = new CargoShip("C1","C3PO",200,"Macedonia","CargoShip",45,400,500);
let mining1 = new MiningShip("M1","obi-wan",300,"Macedonia","Mining Ship","Showel","surface mining",500)



    function showFighter (obj){

    
    $("#Fighter").append (`<li>Name:${obj.name}</li><li>Pilot:${obj.pilot}</li><li>Tank:${obj.fuelTankCapacity}
    <li>Location:${obj.currentLocation}</li><li>Type:${obj.typeOfStarShip}</li><li>Weapons:${obj.weapons}</li><li>Shield:${obj.shield}</li>
    <li>Number:${obj.numberOfKills}</li>`);
    
    
}

function showCargo(obj){
    
    $("#CargoShip").append(`<li>${obj.name}</li><li>Pilot:${obj.pilot}</li><li>Tank:${obj.fuelTankCapacity}
    <li>Location:${obj.currentLocation}</li><li>Type:${obj.typeOfStarShip}</li><li>Capacity:${obj.cargoCapacity}</li><li>Route:${obj.traidingRoute}</li><li>Cranes:${obj.loadingCranes}</li>`)
}

function showMining(obj){
    $("#MiningShip").append(`<li>${obj.name}</li><li>Pilot:${obj.pilot}</li><li>Tank:${obj.fuelTankCapacity}
    <li>Location:${obj.currentLocation}</li><li>Type:${obj.typeOfStarShip}</li><li>Tools:${obj.miningTools}</li>
    <li>Type:${obj.miningTypes}</li><li>Capacity:${obj.miningStorageCapacity}</li>`)
}

// showFighter(fighter1);
// showCargo(cargo1);
// showMining(mining1);

$("#b1").on("click", function(){
 
$("#Fighter").html("");  
showFighter(fighter1);
$("#c").hide();
$("#m").hide();
$("#f").toggle();


});

$("#b2").on("click", function(){
    $("#CargoShip").html("");
    showCargo(cargo1);
    $("#f").hide();
    $("#m").hide();
    $("#c").toggle();
    

});

$("#b3").on("click",function(){
    $("#MiningShip").html("");
    showMining(mining1);
    $("#f").hide();
    $("#c").hide();
    $("#m").toggle();
})

