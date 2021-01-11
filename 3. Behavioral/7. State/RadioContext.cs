namespace Patterns._3._Behavioral._7._State
{
    public class RadioContext
    {
        private IStation _curStation;

        public void SetStation(IStation station)
        {
            _curStation = station;
        }

        public void ChangeToNextStation()
        {
            if (_curStation.GetType() == typeof(FirstRadio))
                SetStation(new SecondStation());
            else if (_curStation.GetType() == typeof(SecondStation))
                SetStation(new ThirdRadio());
            else
                SetStation(new FirstRadio());
        }

        public void Play()
        {
            _curStation.play();
        }
    }
}