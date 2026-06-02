namespace MTWeb.Models.TylerDrive.Setup;

public class GeneralSetupModel
{
    public bool MapUpdatesEnabled { get; set; }
    public string LoginType { get; set; } = "PinOnly";
    public bool AutoLogoutEnabled { get; set; }
    public int AutoLogoutMinutes { get; set; } = 15;
}
