using DungeonDio.src.Characters;

Fighter fighter = new Fighter("Marci", 5, "Lutadora");
Cleric cleric = new Cleric("Mirana", 5, "Clériga");
Thief thief = new Thief("Jack", 5, "Ladrão");
BlackMage mage = new BlackMage("Hudson", 5, "Mago");

Console.WriteLine($"{fighter.Name} é uma {fighter.CharType} de nivel {fighter.Level} | hp:{fighter.hp} / mp:{fighter.mp}");
Console.WriteLine($"{cleric.Name} é uma {cleric.CharType} de nivel {cleric.Level} | hp:{cleric.hp} / mp:{cleric.mp}");
Console.WriteLine($"{thief.Name} é uma {thief.CharType} de nivel {thief.Level} | hp:{thief.hp} / mp:{thief.mp}");
Console.WriteLine($"{mage.Name} é uma {mage.CharType} de nivel {mage.Level} | hp:{mage.hp} / mp:{mage.mp}");    

Console.WriteLine(fighter.Attack(1));
Console.WriteLine(cleric.Attack(1));
Console.WriteLine(thief.Attack(2));
Console.WriteLine(mage.Attack(7));





