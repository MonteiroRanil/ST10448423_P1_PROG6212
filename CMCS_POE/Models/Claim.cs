namespace CMCS_POE.Models;
public class Claim
{
    public int Id { get; set; }
    public string LecturerName { get; set; }
    public string ModuleName { get; set; }
    public int HoursWorked { get; set; }
    public decimal Amount { get; set; }
    public bool IsVerified { get; set; }
    public bool IsApproved { get; set; }
}
