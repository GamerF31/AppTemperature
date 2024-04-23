namespace ChallengeApka
{
    public abstract class TemperaturaBase : ITemperatura
    {
        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public abstract void AddTemp(float temp);

        public abstract void AddTemp(string temp);
        public abstract void AddTemp(double temp);

        public abstract Statistics GetStatistics();
    }
}
