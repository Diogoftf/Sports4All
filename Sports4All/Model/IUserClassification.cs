namespace Sports4All
{
    public interface IUserClassification
    {
        double FairplayAverage { get; set; }
        double SkillAverage { get; set; }
        User User { get; set; }
    }
}