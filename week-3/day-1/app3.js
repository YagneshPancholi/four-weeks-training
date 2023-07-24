function submitForm(){
    var userText = document.getElementById("userTextInput").value;
    document.getElementById("userText").innerHTML = userText;
    var colorName = document.getElementById("bgcolor").value;
    var colorName1 = document.getElementById("hexbgcolor").value.trim();
    if(colorName1.length == 6){
        document.getElementById("userText").style.color = `#${colorName1}`;    
    }else{
        document.getElementById("userText").style.color = colorName;
    }
}