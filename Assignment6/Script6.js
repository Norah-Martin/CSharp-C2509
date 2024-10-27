// JavaScript source code
function counter() {
    var time = parseInt(document.getElementById("time").value);
    var count = document.getElementById('demo');

    var countdown = setInterval(function () {


        count.textContent = time + "seconds remaining";
        time--;

        if (time < 0) {
            clearInterval(countdown)
            count.textContent = "time up";
        }
    }, 1000);
}