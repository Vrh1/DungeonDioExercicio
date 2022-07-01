using DungeonDio.src.Characters;

Fighter fighter = new Fighter("Marci", 5, "Lutadora");
Cleric cleric = new Cleric("Mirana", 5, "Clériga");
Thief thief = new Thief("Jack", 5, "Ladrão");
BlackMage mage = new BlackMage("Hudson", 5, "Mago");

Console.WriteLine(fighter.ToString());
Console.WriteLine(cleric.ToString());
Console.WriteLine(thief.ToString());
Console.WriteLine(mage.ToString());

Console.WriteLine(fighter.Attack(1));
Console.WriteLine(cleric.Attack(1));
Console.WriteLine(thief.Attack(2));
Console.WriteLine(mage.Attack(7));





