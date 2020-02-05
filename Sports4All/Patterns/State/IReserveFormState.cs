namespace Sports4All.Patterns.State
{
    public interface IReserveFormState : IUserControl
    {
        void NextScreen();
        void PreviousScreen();
        void Display();
    }
}
