class Car{
    make : string;
    model : string;
    year : number;
    constructor(make:string, model:string, year:number){
        this.make = make;
        this.model = model;
        this.year = year;
    }
    displayCarInfo():void {
        let car = new Car(
            (<HTMLInputElement>document.getElementById("carMake")).value,
            (<HTMLInputElement>document.getElementById("carModel")).value,
            parseInt((<HTMLInputElement>document.getElementById("carYear")).value)
        );
        console.log(`${car.make} created ${car.model} car in the ${car.year} year`);
    }
}

function displayInfo():void{
    let seeMe = <HTMLElement>document.getElementById("see");
    if(seeMe!= null){
        seeMe.style.display = "inline";
    }
    let car = new Car(
        (<HTMLInputElement>document.getElementById("make")).value,
        (<HTMLInputElement>document.getElementById("model")).value,
        parseInt((<HTMLInputElement>document.getElementById("year")).value)
    );
    console.log(`${car.make} created ${car.model} car in the ${car.year} year`);
    let make = document.getElementById("carMake");
    if(make != null){
        make.innerHTML = car.make;
    }
    let model = document.getElementById("carModel");
    if(model != null){
        model.innerHTML = car.model;
    }
    let year = document.getElementById("carYear");
    if(year != null){
        year.innerHTML = car.year +"";
    }
}
// let car1 = new Car("Tata","Nano",2010);
// car1.displayCarInfo();
// let car2 = new Car("Suzuki", "Swift", 2005);
// car2.displayCarInfo();