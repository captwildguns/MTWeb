namespace MTWeb.Models.TylerDrive.Setup;

public class GeneralSetupModel
{
    public bool EnableAutoLogout { get; set; }
    public int AutoLogoutMinutes { get; set; } = 15;
    public string LoginType { get; set; } = "EmployeePin";
}
