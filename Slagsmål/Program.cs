// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the ring. What's your name?");
string name = Console.ReadLine();
Console.WriteLine($"Alright {name} you'll be fighting Enemy, so get ready.");
Console.ReadKey();
int player_hp = 150;
int enemy_hp = 150;

Random generator = new Random();

Console.WriteLine($"{name}'s health: {player_hp}  Enemy health: {enemy_hp}");

while (player_hp > 0 && enemy_hp > 0)
{

 int player_dmg = generator.Next(10, 45);
 int enemy_dmg = generator.Next(10, 45);
 
 
 player_hp -= enemy_dmg;
 enemy_hp -= player_dmg;

 Console.WriteLine("-------------------------------------");
 
 Console.WriteLine($"{name} has done {player_dmg} damage to Enemy");
 Console.WriteLine($"Enemy has done {enemy_dmg} damage to {name}");
 
 Console.WriteLine("[Press any key to continue]");
 Console.ReadKey();
 Console.WriteLine();
 Console.WriteLine();
 
 


 if(player_hp > 0 && enemy_hp > 0)
 {
      Console.WriteLine($"{name}'s health: {player_hp}  Enemy health: {enemy_hp}");
 }
   
}

 
 if(player_hp <= 0)
 {
    Console.WriteLine($"Enemy has won this round!");
 }

 else if(enemy_hp <= 0)
 {
    Console.WriteLine($"{name} has won this round!");
 }
 else if(enemy_hp <= 0 && player_hp <= 0)
 {
    Console.WriteLine($"This round is a draw!");
 }
Console.ReadKey();






