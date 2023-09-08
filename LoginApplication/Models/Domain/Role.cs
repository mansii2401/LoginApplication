using System.Text.Json.Serialization;

namespace LoginApplication.Models.Domain
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Role
    {
        Student,
        Employee,

    }
}
