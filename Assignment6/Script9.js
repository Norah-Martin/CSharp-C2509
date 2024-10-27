// JavaScript source code
function start() {
    const today = new Date();
    let h = today.getHours();
    let m = today.getMinutes();
    let s = today.getSeconds();
    document.getElementById('demo').innerHTML = h + ":" + m + ":" + s;
    setTimeout(start, 1000); //execute function after waiting sometime

}