using System.Text.Json.Serialization;

namespace HW1.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FuelType
    {
        Diesel = 1,
        Petrol = 2,
        LPG = 3,
        Hybrid = 4,
        Electric = 5,
    }
}
