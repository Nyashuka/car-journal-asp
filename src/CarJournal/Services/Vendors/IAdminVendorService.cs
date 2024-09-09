using CarJournal.Domain;

namespace CarJournal.Services.Vendors;

public interface IAdminVendorService
{
    Task<VendorResult> CreateVendor(string name);
    VendorResult EditVendor(int id, string name);
    void DeleteVendor(int id);
    List<Vendor> GetVendors();
}