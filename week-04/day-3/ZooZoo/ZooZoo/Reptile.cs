namespace ZooZoo
{
    internal class Reptile : Animal
    {
        

        public Reptile(string name) : base(name)
        {

        }

        public override string Greet()
        {
            return name;
        }

        public override string WantChild()
        {
            string child = "";
            

            if (name == "frog" || name == "Frog")
                {
                child = "wants a child but Im not sure what frogs do!";
            }
            
            else
            {
                child = "wants a child from an egg!";
            }
            return child;
        }
    }
}