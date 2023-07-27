function greet(name:string){
        console.log(`Hello ${name}`);
}
greet("yagnesh")
greet("Drashti");
greet("Kunal");

function greet2():void{
    let name = (<HTMLInputElement>document.getElementById("name")).value;
    let x = document.getElementById("greet");
    if(x){
        x.innerHTML = `Hello ${name}`;
    }
}