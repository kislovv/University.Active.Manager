using System;

namespace University.Active.Manager.Web.Configuration;

public class TokenOptions
{
    public TimeSpan ExpiryDuration { get; set; }
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string Key { get; set; }
}