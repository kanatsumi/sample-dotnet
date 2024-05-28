using ClinicBookingSystem_BusinessObject.Enums;

namespace ClinicBookingSystem_BusinessObject.Entities;

public class Service
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int ExpectedDurationInMinute { get; set; }
    public ServiceType ServiceType { get; set; }
    
    //Specification
    public int SpecificationId { get; set; }
    public Specification Specification { get; set; }
    //Appointment
    public ICollection<Appointment> Appointments { get; set; }
}