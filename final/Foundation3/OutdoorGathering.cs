using System;
namespace Foundation3;

class OutdoorGathering : Event
{
    private string weather;

    public OutdoorGathering(string title, string description, DateTime dateTime, Address address, string weather)
        : base(title, description, dateTime, address)
    {
        this.weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather: {weather}";
    }
}
