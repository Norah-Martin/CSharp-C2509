// JavaScript source code
function check() {
    let num = parseFloat(document.getElementById("num").value)
    let result;
    
    if (num % 2 == 0) {
        result="even";

    }
    else {
       result= "odd";
    }
    document.getElementById("result").textContent= "Result is:"+result;
}
