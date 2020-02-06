namespace Sports4All
{
    public class ExpertReserveStrategy : IReserveStrategy
    {
        public void DisplayReserveForm()
        {
            Form1.Instance.BringUcToFront<UC_CreateEvent>("UC_CreateEvent", "");
        }
    }
}
