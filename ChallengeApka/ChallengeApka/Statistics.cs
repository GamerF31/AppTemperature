
namespace ChallengeApka
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public  float Sum { get; private set; }
        public int count { get; private set; }
        public float Average { get
        {
                return this.Sum / this.count;
            }
        }
        public string Season { get; private set; }
        
        public Statistics() 
        {
            this.Sum = 0;
            this.count = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
            this.Season = "";
        }
        public void AddTemp(float temp)
        {
            this.Sum+=temp;
            this.count++;
            this.Min = Math.Min(this.Min, temp);
            this.Max = Math.Max(this.Max, temp);
        }
    }
}
