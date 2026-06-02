namespace MTWeb.Models.TylerDrive.Setup;

public class TimeTrackingSetupModel
{
    public bool EnableTimekeeping { get; set; }
    public bool MandatoryPunch { get; set; }
    public int? PunchInBufferMinutes { get; set; }
    public int? PunchOutBufferMinutes { get; set; }
    public string BreakTime { get; set; } = "Off";
}
