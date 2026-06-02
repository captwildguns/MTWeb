namespace MTWeb.Models.TylerDrive.Setup;

public class TimeTrackingSetupModel
{
    public bool TimekeepingEnabled { get; set; } = true;
    public bool MandatoryPunchIn { get; set; }
    public int ClockInBufferMinutes { get; set; } = 15;
    public int ClockOutBufferMinutes { get; set; } = 15;
    public string BreakTime { get; set; } = "Off";
}
