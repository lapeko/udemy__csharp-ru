using chapter5_oop;

Character character = new Character();

Console.WriteLine(character.Health);
character.Hit(20);
Console.WriteLine(character.Health);
character.Hit(200);
Console.WriteLine(character.Health);
