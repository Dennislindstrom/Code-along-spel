//Welcome player to the game
// Decide monster and player health
// See who goes first


//loop
//Attack
//Calculate damage
//Subtract damage
//Change turn 




//VARIABLES
int playerHealth;
int monsterHealth;



//METHOD CALLS
WelcomePlayer();
DecidePlayerAndMonsterHealth();


//METHODS

//Welcome player to the game
void WelcomePlayer()
{
    Console.WriteLine("--------------------------");
    Console.WriteLine("Welcome to the battle game");
    Console.WriteLine("    Winner of all awards  ");
    Console.WriteLine("--------------------------");
}


// Ask player for monster and player health, funktion.
void DecidePlayerAndMonsterHealth()
{
    Console.WriteLine();
    Console.Write("What should player HP be? ");
    int playerhealth = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Great! What should monster HP be? ");
    int monsterhealth = Convert.ToInt32(Console.ReadLine());

}
