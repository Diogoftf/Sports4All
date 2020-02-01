namespace Sports4All
{
    public interface IUserEvaluation
    {
        User Evaluated { get; set; }
        int FairPlay { get; set; }
        int Skill { get; set; }
        string UserId { get; set; }
    }
}