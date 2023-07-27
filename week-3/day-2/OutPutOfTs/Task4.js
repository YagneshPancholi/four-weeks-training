"use strict";
class Car {
    constructor(make, model, year) {
        this.make = make;
        this.model = model;
        this.year = year;
    }
    displayCarInfo() {
        let car = new Car(document.getElementById("carMake").value, document.getElementById("carModel").value, parseInt(document.getElementById("carYear").value));
        console.log(`${car.make} created ${car.model} car in the ${car.year} year`);
    }
}
function displayInfo() {
    let seeMe = document.getElementById("see");
    if (seeMe != null) {
        seeMe.style.display = "inline";
    }
    let car = new Car(document.getElementById("make").value, document.getElementById("model").value, parseInt(document.getElementById("year").value));
    console.log(`${car.make} created ${car.model} car in the ${car.year} year`);
    let make = document.getElementById("carMake");
    if (make != null) {
        make.innerHTML = car.make;
    }
    let model = document.getElementById("carModel");
    if (model != null) {
        model.innerHTML = car.model;
    }
    let year = document.getElementById("carYear");
    if (year != null) {
        year.innerHTML = car.year + "";
    }
}
// let car1 = new Car("Tata","Nano",2010);
// car1.displayCarInfo();
// let car2 = new Car("Suzuki", "Swift", 2005);
// car2.displayCarInfo();
