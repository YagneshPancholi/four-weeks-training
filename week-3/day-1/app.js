var greetBtn = document.getElementById("greetBtn");
var sumBtn = document.getElementById("sumBtn");
var arrBtn = document.getElementById("arrBtn");
var revStr = document.getElementById("revStr");

greetBtn.addEventListener("click", greetFunction);
sumBtn.addEventListener("click", sumFunction);
arrBtn.addEventListener("click", arrFunction);
revStr.addEventListener("click",revStrFunction);

function revStrFunction(){
    let str = prompt("Enter Your String: ");
    let ans = str.split("").reverse().join("");
    alert(str + " reversed String = "+ ans);
}

function greetFunction(){
    var name = prompt("Please, Enter Your Name: ","FirstName LastName");
    let greet = "Good Morning, " + name;
    alert(greet)
}

function sumFunction(){
    var num1 = prompt("Enter First Number: ");
    var num2 = prompt("Enter Second Number: ");
    var sum = parseInt(num1) + parseInt(num2);
    var answer = num1+" + "+num2+" = "+sum;
    alert(answer)
}

function arrFunction(){
    var numbers = [];
    var count = prompt("Enter Size of Array: ");
    for(let i = 0; i < count; i++){
        numbers[i] = prompt("Enter "+ (i+1) +" Number: ");
    }
    var numbers2 = [1,2,3];

    console.log(numbers);
    console.log(numbers2);
    console.log(numbers.filter(x => numbers2.includes(x)));
    console.log(typeof(countOccurance(numbers)));
    console.log(countOccurance(numbers));

    console.log("Unique Numbers: ");
    var uniqueNumbers = new Set(numbers);
    // var ans = JSON.stringify(uniqueNumbers);
    uniqueNumbers = Array.from(uniqueNumbers);
    console.log(uniqueNumbers);
    
}

function countOccurance(arr){
    var Occurances = {};
    for( let j = 0; j < arr.length; j++ ){
        var elmt =arr[j];
        if(Occurances[elmt]){
            Occurances[elmt]++;
        }else{
            Occurances[elmt] = 1;
        }
    }
   return Occurances;
}