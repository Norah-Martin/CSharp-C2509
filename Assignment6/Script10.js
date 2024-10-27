// JavaScript source code
function ten() { 
    let amount = parseFloat(document.getElementById("amount").value);
    let result=amount-(amount*0.1);
    document.getElementById("result").innerHTML =result ;
    }
function fifty() {
    let amount = parseFloat(document.getElementById("amount").value);
    let result=amount-(amount*0.5);
    document.getElementById("result").innerHTML =result ;
    

}
function hund() {
    let amount = parseFloat(document.getElementById("amount").value);
    let result=amount-(amount*1);
    document.getElementById("result").innerHTML =result ;
    

}

