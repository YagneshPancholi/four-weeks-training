interface Person{
    firstName:string;
    lastName:string;
    age:number;

}

function introduce(person:Person):void {
    
    console.log(`${person.firstName} ${person.lastName} is ${person.age} years Old.`);
}

const person1 : Person = {
    firstName :"yagnesh",
    lastName : "pancholi",
    age : 20
};
introduce(person1);