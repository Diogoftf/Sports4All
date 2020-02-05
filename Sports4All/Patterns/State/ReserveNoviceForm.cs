using System;

namespace Sports4All.Patterns.State
{
    public class ReserveNoviceForm
    {
        public IReserveFormState EventNameState { get; }
        public IReserveFormState SelectSportState { get; }
        public IReserveFormState SelectLocationState { get; }
        public IReserveFormState SelectHourParkState { get; }
        public IReserveFormState AskForMaterialState { get; }
        public IReserveFormState SelectMaterialState { get; }
        public IReserveFormState DefineUsersState { get; }
        public IReserveFormState ShowPriceState { get; }

        private IReserveFormState _state;

        public ReserveNoviceForm()
        {
            //EventNameState = new EventNameState(this);
            //SelectSportState = new SelectSportState(this);
            //SelectLocationState = new SelectLocationState(this);
            //SelectHourParkState = new SelectHourParkState(this);
            //AskForMaterialState = new AskForMaterialState(this);
            //SelectMaterialState = new SelectMaterialState(this);
            //DefineUsersState = new DefineUsersState(this);
            //ShowPriceState = new ShowPriceState(this);

            _state = EventNameState;
            _state.Display();
        }


        public void SetState(IReserveFormState state)
        {
            _state = state;
            _state.Display();
        }

        public IReserveFormState GetState()
        {
            return _state;
        }

        public void NextScreen()
        {
            _state.NextScreen();
        }

        public void PreviousScreen()
        {
            _state.PreviousScreen();
        }
    }
}
