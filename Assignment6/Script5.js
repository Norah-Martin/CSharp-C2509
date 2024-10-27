// JavaScript source code
function Convert() {
    
    let temp = parseFloat(document.getElementById("temp").value);
    let fahr = (temp * (9 / 5)) + 32;
    document.getElementById("result").innerHTML = fahr;
}