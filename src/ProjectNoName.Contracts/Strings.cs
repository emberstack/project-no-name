
namespace ProjectNoName.Contracts
{
  public static class Strings
    {
        public static string HubUrl => "http://localhost:5001/hubs/clock";

        public static class Events
        {
            public static string TimeSent => nameof(IClock.ShowTime);
        }
    }

}