using System.Text.Json.Serialization;

namespace TheCompanyIn.Controllers
{
    public class Company
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("legalName")]
        public string LegalName { get; set; }

        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        [JsonPropertyName("domainAliases")]
        public List<string> DomainAliases { get; set; }

        [JsonPropertyName("site")]
        public Site Site { get; set; }

        [JsonPropertyName("category")]
        public Category Category { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("foundedYear")]
        public long? FoundedYear { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }

        [JsonPropertyName("utcOffset")]
        public long? UtcOffset { get; set; }

        [JsonPropertyName("geo")]
        public Geo Geo { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("linkedin")]
        public Linkedin Linkedin { get; set; }

        [JsonPropertyName("twitter")]
        public Twitter Twitter { get; set; }

        [JsonPropertyName("crunchbase")]
        public Crunchbase Crunchbase { get; set; }

        [JsonPropertyName("emailProvider")]
        public bool EmailProvider { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("ticker")]
        public object Ticker { get; set; }

        [JsonPropertyName("identifiers")]
        public Identifiers Identifiers { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("metrics")]
        public Metrics Metrics { get; set; }

        [JsonPropertyName("indexedAt")]
        public DateTime IndexedAt { get; set; }

        [JsonPropertyName("tech")]
        public List<string> Tech { get; set; }

        [JsonPropertyName("techCategories")]
        public List<string> TechCategories { get; set; }

        [JsonPropertyName("parent")]
        public Parent Parent { get; set; }

        [JsonPropertyName("ultimate_parent")]
        public UltimateParent UltimateParent { get; set; }
    }
    public class Category
    {
        [JsonPropertyName("sector")]
        public string Sector { get; set; }

        [JsonPropertyName("industryGroup")]
        public string IndustryGroup { get; set; }

        [JsonPropertyName("industry")]
        public string Industry { get; set; }

        [JsonPropertyName("subIndustry")]
        public string SubIndustry { get; set; }

        [JsonPropertyName("sicCode")]
        public string SicCode { get; set; }

        [JsonPropertyName("naicsCode")]
        public string NaicsCode { get; set; }
    }

    public class Crunchbase
    {
        [JsonPropertyName("handle")]
        public string Handle { get; set; }
    }

    public class Geo
    {
        [JsonPropertyName("streetNumber")]
        public string StreetNumber { get; set; }

        [JsonPropertyName("streetName")]
        public string StreetName { get; set; }

        [JsonPropertyName("subPremise")]
        public object SubPremise { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("stateCode")]
        public string StateCode { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lng")]
        public double Lng { get; set; }
    }

    public class Identifiers
    {
        [JsonPropertyName("usEIN")]
        public string UsEIN { get; set; }
    }

    public class Linkedin
    {
        [JsonPropertyName("handle")]
        public string Handle { get; set; }
    }

    public class Metrics
    {
        [JsonPropertyName("alexaUsRank")]
        public long? AlexaUsRank { get; set; }

        [JsonPropertyName("alexaGlobalRank")]
        public long? AlexaGlobalRank { get; set; }

        [JsonPropertyName("employees")]
        public long? Employees { get; set; }

        [JsonPropertyName("employeesRange")]
        public string EmployeesRange { get; set; }

        [JsonPropertyName("marketCap")]
        public long MarketCap { get; set; }

        [JsonPropertyName("raised")]
        public long? Raised { get; set; }

        [JsonPropertyName("annualRevenue")]
        public long? AnnualRevenue { get; set; }

        [JsonPropertyName("estimatedAnnualRevenue")]
        public string EstimatedAnnualRevenue { get; set; }

        [JsonPropertyName("fiscalYearEnd")]
        public long? FiscalYearEnd { get; set; }
    }

    public class Parent
    {
        [JsonPropertyName("domain")]
        public object Domain { get; set; }
    }

    public class Site
    {
        [JsonPropertyName("phoneNumbers")]
        public List<object> PhoneNumbers { get; set; }

        [JsonPropertyName("emailAddresses")]
        public List<object> EmailAddresses { get; set; }
    }

    public class Twitter
    {
        [JsonPropertyName("handle")]
        public string Handle { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("bio")]
        public string Bio { get; set; }

        [JsonPropertyName("followers")]
        public long? Followers { get; set; }

        [JsonPropertyName("following")]
        public long? Following { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("site")]
        public string Site { get; set; }

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    }

    public class UltimateParent
    {
        [JsonPropertyName("domain")]
        public object Domain { get; set; }
    }



}