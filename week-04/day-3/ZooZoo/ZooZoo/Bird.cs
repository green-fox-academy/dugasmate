namespace ZooZoo
{
    internal class Bird : Animal 
    {


        public Bird(string name) : base(name)
        {

        }

        public override string Greet()
        {
            return name;
        }

        public override string WantChild()
        {
            string child = "wants a child from an egg!";
            return child;
        }
    }
}