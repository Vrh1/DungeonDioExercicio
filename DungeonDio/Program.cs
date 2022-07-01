using DungeonDio.src.Characters;

Fighter fighter = new Fighter("Marci", 5, "Lutadora");
Cleric cleric = new Cleric("Mirana", 5, "Clériga");
Thief thief = new Thief("Huscky", 5, "Ladrão");
BlackMage mage = new BlackMage("Hudson", 5, "Mago");

Console.WriteLine(fighter.ToString());
Console.WriteLine(cleric.ToString());
Console.WriteLine(thief.ToString());
Console.WriteLine(mage.ToString());

Console.WriteLine(fighter.Attack());
Console.WriteLine(cleric.Attack());
Console.WriteLine(thief.Attack());
Console.WriteLine(mage.Attack());





