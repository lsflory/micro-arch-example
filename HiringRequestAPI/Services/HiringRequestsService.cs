using HiringRequestAPI.Models;

namespace HiringRequestAPI.Services;

public static class HiringRequestsService
{
    static List<HiringRequest> HiringRequests { get; }
    static int nextId = 7;
    static HiringRequestsService()
    {
        HiringRequests = new List<HiringRequest>
        {
          new HiringRequest { Id = 1, CreatedDate = DateTime.Now, RequestNumber = "TEST-15465-1", HiringOrganization = "Hiring Office One", HiringOfficial = "Sample User-One", Source = 0, RequestType = 0 },
          new HiringRequest { Id = 2, CreatedDate = DateTime.Now, RequestNumber = "TEST-15465-2", HiringOrganization = "Hiring Office Two", HiringOfficial = "Sample User-Two", Source = 0, RequestType = 1 },
          new HiringRequest { Id = 3, CreatedDate = DateTime.Now, RequestNumber = "TEST-15465-3", HiringOrganization = "Hiring Office Three", HiringOfficial = "Sample User-Three", Source = 0, RequestType = 2 },
          new HiringRequest { Id = 4, CreatedDate = DateTime.Now, RequestNumber = "TEST-15465-4", HiringOrganization = "Hiring Office Four", HiringOfficial = "Sample User-Four", Source = 1, RequestType = 0 },
          new HiringRequest { Id = 5, CreatedDate = DateTime.Now, RequestNumber = "TEST-15465-5", HiringOrganization = "Hiring Office Five", HiringOfficial = "Sample User-Five", Source = 1, RequestType = 1 },
          new HiringRequest { Id = 6, CreatedDate = DateTime.Now, RequestNumber = "TEST-15465-6", HiringOrganization = "Hiring Office Six", HiringOfficial = "Sample User-Six", Source = 1, RequestType = 2 }
        };
    }

    public static List<HiringRequest> GetAll() => HiringRequests;

    public static HiringRequest? Get(int id) => HiringRequests.FirstOrDefault(request => request.Id == id);

    public static HiringRequest Add(HiringRequest HiringRequest)
    {
      HiringRequest.Id = nextId++;
      HiringRequests.Add(HiringRequest);

      return HiringRequest;
    }

    public static void Delete(int id)
    {
      var HiringRequest = Get(id);
      if(HiringRequest is null)
        return;

      HiringRequests.Remove(HiringRequest);
    }

    public static void Update(HiringRequest HiringRequest)
    {
      var index = HiringRequests.FindIndex(request => request.Id == HiringRequest.Id);
      if(index == -1)
        return;

      HiringRequests[index] = HiringRequest;
    }
}