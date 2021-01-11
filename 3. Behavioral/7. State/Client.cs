namespace Patterns._3._Behavioral._7._State
{
    public class Client
    {
        public static void Main()
        {
            var radio_station = new RadioContext();
            var radio1 = new FirstRadio();
            radio_station.SetStation(radio1);
            
            for (var i = 0; i < 10; ++i)
            {
                radio_station.Play();
                radio_station.ChangeToNextStation();
            }
        }
    }
}