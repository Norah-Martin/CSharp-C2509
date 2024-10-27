// JavaScript source code
var c=0;
function begin()
{
     c++;
            var minutes = Math.floor(c / 60);
            var seconds = c % 60;
            document.getElementById("demo").innerHTML = 
                (minutes < 10 ? "0" + minutes : minutes) + ":" + 
                (seconds < 10 ? "0" + seconds : seconds);
}s
function reset() {
            clearInterval(start);  
            c = 0;
            document.getElementById("demo").innerHTML = "00:00";  
        }
