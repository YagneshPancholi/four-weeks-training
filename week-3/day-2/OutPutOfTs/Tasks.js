"use strict";
function greet(name) {
    console.log(`Hello ${name}`);
}
greet("yagnesh");
greet("Drashti");
greet("Kunal");
function greet2() {
    let name = document.getElementById("name").value;
    let x = document.getElementById("greet");
    if (x) {
        x.innerHTML = `Hello ${name}`;
    }
}
