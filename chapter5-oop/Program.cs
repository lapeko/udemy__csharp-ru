// See https://aka.ms/new-console-template for more information

using chapter5_oop;

Character character = new Character();

Console.WriteLine(character.Health);
character.Hit(25);
Console.WriteLine(character.Health);