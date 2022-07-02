using DungeonDio.src.Characters;

Fighter fighter = new Fighter("Marci", 5, "Lutadora");
Cleric cleric = new Cleric("Mirana", 5, "Clériga");
Thief thief = new Thief("Jack", 5, "Ladrão");
BlackMage mage = new BlackMage("Hudson", 5, "Mago");

Console.WriteLine($"{fighter.name} é uma {fighter.charType} de nivel {fighter.level} | hp:{fighter.hp} / mp:{fighter.mp}");
Console.WriteLine($"{cleric.name} é uma {cleric.charType} de nivel {cleric.level} | hp:{cleric.hp} / mp:{cleric.mp}");
Console.WriteLine($"{thief.name} é uma {thief.charType} de nivel {thief.level} | hp:{thief.hp} / mp:{thief.mp}");
Console.WriteLine($"{mage.name} é uma {mage.charType} de nivel {mage.level} | hp:{mage.hp} / mp:{mage.mp}");

Console.WriteLine(fighter.Attack(1));
Console.WriteLine(cleric.Attack(1));
Console.WriteLine(thief.Attack(2));
Console.WriteLine(mage.Attack(7));





