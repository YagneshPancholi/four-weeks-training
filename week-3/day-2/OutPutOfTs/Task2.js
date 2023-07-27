"use strict";
function introduce(person) {
    console.log(`${person.firstName} ${person.lastName} is ${person.age} years Old.`);
}
const person1 = {
    firstName: "yagnesh",
    lastName: "pancholi",
    age: 20
};
introduce(person1);
