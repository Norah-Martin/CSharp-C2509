// JavaScript source code
function add(){
    let num1 = parseFloat(document.getElementById("num1").value);
    let num2 = parseFloat(document.getElementById("num2").value);
    let result = num1 + num2;
    document.getElementById("result").innerHTML = result;

}
function sub() {
    let num1 = parseFloat(document.getElementById("num1").value);
    let num2 = parseFloat(document.getElementById("num2").value);
    let result = num1 -num2;
    document.getElementById("result").innerHTML = result;

}
function mul() {
    let num1 = parseFloat(document.getElementById("num1").value);
    let num2 = parseFloat(document.getElementById("num2").value);
    let result = num1 * num2;
    document.getElementById("result").innerHTML = result;

}
function div() {

    let num1 = parseFloat(document.getElementById("num1").value);
    let num2 = parseFloat(document.getElementById("num2").value);
    if (num2!=0) {
        let result = num1 + num2;
        document.getElementById("result").innerHTML = result;
    }
    else {
        document.getElementById("result").textContent = "sorry";
    }

}
