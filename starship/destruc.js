class Starship {
    constructor({ name,pilot,fuelTankCapacity,currentLocation,typeOfStarShip }) {
        this.name=name
        this.pilot=pilot;
        this.fuelTankCapacity=fuelTankCapacity;
        this.currentLocation=currentLocation;
        this.typeOfStarShip=typeOfStarShip;
        
    }
}

class Fighter extends Starship {
    constructor({name,pilot,fuelTankCapacity,currentLocation,typeOfStarShip,weapons,shield,numberOfKills}){
        super({name,pilot,fuelTankCapacity,currentLocation,typeOfStarShip})
        this.weapons=weapons;
        this.shield=shield;
        this.numberOfKills=numberOfKills;
    }
    shootWeapon1(){
        
    }
}

class CargoShip extends Starship{
    constructor({name,pilot,fuelTankCapacity,currentLocation,typeOfStarShip,cargoCapacity,traidingRoute,loadingCranes}){
        super({name,pilot,fuelTankCapacity,currentLocation,typeOfStarShip});
        this.cargoCapacity=cargoCapacity;
        this.traidingRoute=traidingRoute;
        this.loadingCranes=loadingCranes;
    }
    load(){

    }
    unload(){

    }
}

class MiningShip extends Starship{
    constructor({name,pilot,fuelTankCapacity,currentLocation,typeOfStarShip,miningTools,miningTypes,miningStorageCapacity}){
        super({name,pilot,fuelTankCapacity,currentLocation,typeOfStarShip});
        this.miningTools=miningTools;
        this.miningTypes=miningTypes;
        this.miningStorageCapacity=miningStorageCapacity;

    }
    mine(){

    }
    setStorageTemperature(){

    }
}


function readValues(){
    let obj ={};
    obj.name=$("#Name").val(); 
    obj.pilot=$("#Pilot").val();
    obj.fuelTankCapacity=$("#fuelTankCapacity").val();
    obj.currentLocation=$("#currentLocation").val();
    obj.typeOfStarShip=$("#typeOfStarShip").val();
    obj.weapons=$("#weapons").val();
    obj.shield=$("#shield").val();
    return obj
}

function showNewStarship({ name, pilot, fuelTankCapacity, currentLocation, typeOfStarShip,weapons,shield }) {
    $('#starships').append(`
        <tr>
            <td>${name}</td>
            <td>${pilot}</td>
            <td>${fuelTankCapacity}</td>
            <td>${currentLocation}</td>
            <td>${typeOfStarShip}</td>
            <td>${weapons}</td>
            <td>${shield}</td>
        </tr>
    `)
}

$('#getInfo').on('click', () => {
    let values = readValues()
    let model = new Fighter(values)
    
    showNewStarship(model)
    console.log(model);
})

