using Sports4All.Patterns.State;

namespace Sports4All
{
    public class NoviceReserveStrategy : IReserveStrategy
    {
        public void DisplayReserveForm()
        {
            ReserveNoviceForm reserveNoviceForm = new ReserveNoviceForm();
        }
    }
}
