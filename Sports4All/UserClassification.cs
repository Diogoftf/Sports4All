namespace Sports4All
{
    public class UserClassification : Classification
    {
        public double FairplayAverage { get; set; }
        public double SkillAverage { get; set; }
        public virtual User User { get; set; }
    }
}
