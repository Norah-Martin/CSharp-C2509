//const form = document.getElementById("quiz form");
//const result = document.getElementById("score");
//const Answer = document.getElementById("answers");
//const Wrong = document.getElementById("wrong");
//form.addEventListener("submit", function (event) {
//    event.preventDefault();
//    let score = 0;
//    const totalQuestions = 3;

//    const answers = document.querySelectorAll('input[type="radio"]:checked');
//    let correctAnswers = [];
//    let wrongAnswers = [];
//    answers.forEach((answer) => {
//        if (answer.value === "correct") {
//            score++;
//            correctAnswers.push(answer.nextSibling.data);
//        }
//        else {
//            wrongAnswers.push(answer.nextSibling.data);
//        }
//    });
//    result.textContent = `You scored ${score} out of ${totalQuestions}. `;
//    Answer.textContent = 'The right answers are: ${ correctAnswers.toString() }';
//    Wrong.textContent =' The wrong answers are: ${ wrongAnswers.toString() }';

//    if (score == totalQuestions) {
//        result.style.color = "green";
//        result.textContent += "Great Job!";
//    }
//    else {
//        result.style.color = "red";
//        result.textContent += "Try Again.";
//    }
//});
