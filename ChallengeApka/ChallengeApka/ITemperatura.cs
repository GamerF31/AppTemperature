namespace ChallengeApka
{
    public interface ITemperatura
    {
        void AddTemp(float temp);

        void AddTemp(string temp);
        void AddGrade(double grade);

        Statistics GetStatistics();
    }
}
