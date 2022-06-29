namespace CircusTrainApp
{
    public class Animal
    {
        public Size Size { get; private set; }
        public EatingPreference EatingPreference { get; private set; }

        public Animal(Size size, EatingPreference eatingPreference)
        {
            this.Size = size;
            this.EatingPreference = eatingPreference;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Size, EatingPreference);
        }
    }
}
