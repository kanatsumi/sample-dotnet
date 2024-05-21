using ClinicBookingSystem_BusinessObject.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClinicBookingSystem_BusinessObject.Entities
{
    public class User : BaseEntities
    {
        [Key]
        public long Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public string PasswordHash { get; set; }
        public Boolean EmailConfirmed { get; set; } = false;
        public Boolean PhoneConfirmed { get; set; } = false;
        [JsonIgnore]
        public string EmailCode { get; set; }
        public string Address { get; set; }
        [JsonIgnore]
        public string PhoneCode { get; set; }
        public string PhoneNumber {  get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Các thuộc tính thuộc lịch nghỉ làm của nhân viên
        public int TotalDateOff {  get; set; }
        public int DateOffCount {  get; set; }
        public int TotalEmergencyDateOffAttempt { get; set; }
        public int EmergencyDateOffAttemptCount { get; set; }
        public Boolean IsOnDateOff { get; set; }
        public JobStatus JobStatus {  get; set; }
        public DateTimeOffset StartDateOff {  get; set; }
        public DateTimeOffset EndDateOff { get; set;}

        //Role

        public int RoleId { get; set; }
        public Role Role { get; set; }
        public Boolean isStaff => Equals(Role, RoleEnums.Staff);
        public Boolean isClincOwner => Equals(Role, RoleEnums.ClinicOwner);
        public Boolean isDentist => Equals(Role, RoleEnums.Dentist);
        public Boolean isCustomer => Equals(Role, RoleEnums.Customer);
    }
}
