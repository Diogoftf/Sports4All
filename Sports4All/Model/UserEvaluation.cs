namespace Sports4All
{
    public class UserEvaluation : Evaluation
    {
        public int Skill { get; set; }
        public int FairPlay { get; set; }
        public User Evaluated { get; set; }
        public string UserId { get; set; }
    }
}
