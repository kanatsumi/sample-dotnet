using System.ComponentModel.DataAnnotations;

namespace ClinicBookingSystem_BusinessObject.Entities;

public class Relative
{
    [Key]
    public int Id { get; set; }
    //User
    public User User { get; set; } 
}