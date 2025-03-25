let titleH1 = document.getElementById("title");
titleH1.style.color = "red";

 function printNumbers() {
   let upto = document.getElementById("upperRange").value;
   titleH1.innerText = "Numbers form 1-"+upto;

   let numbersDiv = document.getElementById("numbers");
     let numbersHtml = "";
    for (let i = 1; i <= upto; i++) {
       numbersHtml = numbersHtml + "<h2 class='badge text-bg-warning'> " + i + "</h2>";
    }
    numbersDiv.innerHTML = numbersHtml;
 }
//function printNumbers() {

    //let titleH1 = document.getElementById("title");
   // titleH1.style.color = "red";
    //titleH1.innerText = "Numbers form 1-500";
    
   // let numbersDiv = document.getElementById("numbers");
   // let numbersHtml = "";
   // for (let i = 1; i <= 500; i++) {
       // numbersHtml = numbersHtml + "<h2 class='badge text-bg-warning'> " + i + "</h2>";
  //  }
  //  numbersDiv.innerHTML = numbersHtml;


