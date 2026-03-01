namespace Classes
{
    public class Character
    {
        // Attributes
        int level;
        string name;
        string character_class;
        
        Dictionary<string, int> stats = [("strength", 0), 
                                         ("agility", 0), 
                                         ("stamina", 0), 
                                         ("health", 0),
                                         ("perception", 0),
                                         ("charisma", 0),
                                         ("mana", 0),
                                         ("vitality", 0),
                                         ("endurance", 0),
                                         ("willpower", 0),
                                         ("luck", 0)];

        /*
            Methods:
                - Attack, Block/Evade/Counter, Enter_Combat, Exit_Combat, Level_Up, Die, Use_Item,
                  ...
        */

        void Attack()
        {
            
        }

        void Defend()
        {
            
        }

        void EnterCombat()
        {
            
        }

        void ExitCombat()
        {
            
        }

        void LevelUp()
        {
            
        }

        void Die()
        {
            
        }

        void UseItem()
        {
            
        }
    }
}