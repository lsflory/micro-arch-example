namespace HiringRequestAPI.Models;

public class HiringRequest
{
    public int  Id { get; set; }

    public string? RequestNumber { get; set; }

    public string? HiringOrganization { get; set; }

    public string? HiringOfficial { get; set; }

    public int? Source { get; set; }

    public int? RequestType {get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime LastModifiedDate { get; set; }

}
