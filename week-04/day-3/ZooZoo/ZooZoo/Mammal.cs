namespace ZooZoo
{
    internal class Mammal :Animal
    {


        public Mammal(string name) : base(name)
        {
        }

        public override string Greet()
        {
            return name;
        }

        public override string WantChild()
        {
           
            string child = "wants a child from her papa " + name;
            return child;
        }
    }
}