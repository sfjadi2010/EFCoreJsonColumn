using System.Net;

namespace EFCoreJsonColumn.Models;

public sealed class ContactDetails
{
    public Address Address { get; set; } = null!;
    public string? Phone { get; set; }
}
