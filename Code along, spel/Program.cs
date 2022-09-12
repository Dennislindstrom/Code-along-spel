/*
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
bool isPlayerTUrn;
int minDamage = 1;
int maxDamage = 100;


//METHOD CALLS
WelcomePlayer();
DecidePlayerAndMonsterHealth();
DecideTurn();
Attack();



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
// Decide if player or monster goes first by creating a number (0 or 1). 
void DecideTurn()
{
    int turn = new Random().Next(0, 2);
    if (turn == 0)
    {
        isPlayerTUrn = true;

        Console.WriteLine();
        Console.WriteLine("Player goes first!");
    }
    else
    {
        isPlayerTUrn= false;

        Console.WriteLine();
        Console.WriteLine("Monster goes first!");
    }
}

// Logic for player and monster attack. 
void Attack()
{
    if (isPlayerTUrn)
    {
        Console.WriteLine("Player attacks!");
        int damage = CalculateDamage();
        monsterHealth = monsterHealth - damage;            // Eller monsterHealth -= damage;
    }
    else
    {

        Console.WriteLine("Monster attacks!");
        int damage = CalculateDamage();
        playerHealth = playerHealth - damage;
        //Calculate damage.
    }
}
//Calculate a random number between Mindamage and maxDamage and return it
int CalculateDamage()
{
    int damage = new Random().Next(minDamage, maxDamage +1);
    return damage;
}

// Welcome player to the game
//Decide player and monster health
// See who goes first

// Loop
// Attack
// Calculate damage
// Subtract health
// Change turn

using System.Transactions;

//VARIABLES
int playerHealth;
int monsterHealth;
bool isPlayerTurn;
int minDamage = 1;
int maxDamage = 100;

//METHOD CALLS
WelcomePlayer();
DecidePlayerAndMonsterHealth();
DecideTurn();
Attack();






//METHODS
//Welcome player to the game
void WelcomePlayer()
{
    Console.WriteLine("--------------------");
    Console.WriteLine("Welcome to the game!");
    Console.WriteLine("--------------------");
}

// Ask player for player and monster health
void DecidePlayerAndMonsterHealth()
{
    Console.WriteLine();
    Console.Write("What should player HP be? ");
    playerHealth = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("What should monster HP be? ");
    monsterHealth = Convert.ToInt32(Console.ReadLine());
}
// Decide if plauyer or monster goes first
void DecideTurn()
{
    int turn = new Random().Next(0, 2);

    if (turn == 0)
    {
        isPlayerTurn = true;
        Console.WriteLine();
        Console.WriteLine("Player goes first!");
    }
    else
    {
        isPlayerTurn = false;
        Console.WriteLine();
        Console.WriteLine("Monster goes first!");
    }
}
// Logic for player and monster attack
void Attack()
{
    Console.WriteLine();
    int damage = CalculateDamage();

    if (isPlayerTurn)
    {
        Console.WriteLine("Player attacks!");
        // Calculate damage
        monsterHealth -= damage;
    }
    else
    {
        Console.WriteLine("Monster attacks!");
        // Calculate damage
        playerHealth -= damage;
    }
}
//Determine random amount between minDamage and maxDamage and return
int CalculateDamage()
{
    int damage = new Random().Next(minDamage, maxDamage + 1);
    return damage;
}

*/





// Welcome player to the game
//Decide player and monster health
// See who goes first

// Loop
// Attack
// Calculate damage
// Subtract health
// Change turn

using System.Transactions;

//VARIABLES
int playerHealth;
int monsterHealth;
bool isPlayerTurn;
int minDamage = 1;
int maxDamage = 100;

//METHOD CALLS
WelcomePlayer();
DecidePlayerAndMonsterHealth();
DecideTurn();
Attack();
ChangeTurn();






//METHODS
//Welcome player to the game
void WelcomePlayer()
{
    Console.WriteLine("--------------------");
    Console.WriteLine("Welcome to the game!");
    Console.WriteLine("--------------------");
}

// Ask player for player and monster health
void DecidePlayerAndMonsterHealth()
{
    Console.WriteLine();
    Console.Write("What should player HP be? ");
    playerHealth = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("What should monster HP be? ");
    monsterHealth = Convert.ToInt32(Console.ReadLine());
}
// Decide if plauyer or monster goes first
void DecideTurn()
{
    int turn = new Random().Next(0, 2);

    if (turn == 0)
    {
        isPlayerTurn = true;
        Console.WriteLine();
        Console.WriteLine("Player goes first!");
    }
    else
    {
        isPlayerTurn = false;
        Console.WriteLine();
        Console.WriteLine("Monster goes first!");
    }
}
// Logic for player and monster attack
void Attack()
{
    Console.WriteLine();
    int damage = CalculateDamage();

    if (isPlayerTurn)
    {
        Console.WriteLine("Player attacks!");
        // Calculate damage
        monsterHealth -= damage;
    }
    else
    {
        Console.WriteLine("Monster attacks!");
        // Calculate damage
        playerHealth -= damage;
    }
}
//Determine random amount between minDamage and maxDamage and return
int CalculateDamage()
{
    int damage = new Random().Next(minDamage, maxDamage + 1);
    return damage;
}
// set the isPlayersTurn bool to false if 
void ChangeTurn()
{
    if (isPlayerTurn)
    {
        isPlayerTurn = false;

    }
    else
    {

    }
        isPlayerTurn= true;
}

void Printhealth()
{
    Console.WriteLine();
    Console.WriteLine($"Player health: {playerHealth}");
    Console.WriteLine($"Player health: {monsterHealth}");
}