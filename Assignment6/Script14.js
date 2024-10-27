// JavaScript source code

const quotes = [
    "Have a GREAT day",
    "You miss 100% of the shots you dont take.",
    "Success is not final, failure is not fatal: It is the courage to continue that counts.",
    "Have fun",
     "its a happy day"
    
];

function generateQ() {
    const randomIndex = Math.floor(Math.random() * quotes.length); //quotes.length so that in valid array range
    document.getElementById("quote").innerText = quotes[randomIndex];
}

   
