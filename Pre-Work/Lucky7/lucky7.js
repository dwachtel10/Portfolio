//initial variables
function rollThemBones() {
var startBet=
document.getElementById("startBet").value;
var cash = 0
var die1 = 0;
var die2 = 0;
var diceTotal = 0;
var totalRolls = 0;
var cash= startBet;
var highestAmount = startBet;
var highestRolls = 0;


//dice rolling
while (cash > 0)
{
totalRolls = totalRolls + 1;
die1 = Math.floor(Math.random() * 6) + 1;
die2 = Math.floor(Math.random() * 6) + 1;
diceTotal = die1 + die2;

//winning roll
if (diceTotal == 7){cash = cash+4;
	if (cash > highestAmount) {
  highestAmount = cash;
  highestRolls = totalRolls;
  }
}

else
//losing roll
{
cash = cash-1
}
}
if (cash <= 0){
document.getElementById("results").style.display = "block";
document.getElementById("results").innerHTML= '<center><span id="tableTitle">Results</span><br><br><table border= 1 style= "width: 90%;"><tr><th class="header">Starting Bet</th><th class="header">$'
+ startBet + 
'</th></tr><tr><td>Total Rolls Before Going Broke</td><td>'
+ totalRolls +
'</td></tr><tr><td>Highest Amount Won</td><td>$'
+ highestAmount +
'</td></tr><tr><td>Roll Count at Highest Amount Won</td><td>'
+ highestRolls + 
'</td></tr></table></center>';

document.getElementById("startButton").innerHTML="Play Again?";


}

}