// JavaScript source code
function addTask() {
    var task = document.getElementById("task").value
    if (task) {
        var li = document.createElement('li');  
        li.textContent = task;

        document.getElementById('tasklist').appendChild(li);  

        document.getElementById('task').value = '';  
    } else {
        alert("Please enter a task");
        document.getElementById('task')
    }
}