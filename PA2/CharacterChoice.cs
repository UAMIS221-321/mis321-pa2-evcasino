namespace PA2
{
    public class CharacterChoice : Character
    {
        public static Character JackSparrow()
        {
            Character x = new Character();
            x.name = "Jack Sparrow";
            x.SetAttackBehavior(new JackSparrowAtk());

            return x;
            
        }
        public static Character WillTurner()
        {
             Character x = new Character();
            x.name = "Will Turner";
            x.SetAttackBehavior(new WillTurnerAtk());

            return x;
            
        }
        public static Character DavyJones()
        {
            Character x = new Character();
            x.name = "Davy Jones";
            x.SetAttackBehavior(new DavyJonesAtk());

            return x;
        }
    }
}