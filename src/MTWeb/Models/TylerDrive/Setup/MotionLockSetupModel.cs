namespace MTWeb.Models.TylerDrive.Setup;

public class MotionLockSetupModel
{
    // Driver mode
    public string DistractedDriverMode { get; set; } = "AllScreens";

    // Display elements
    public bool ShowClock { get; set; } = true;
    public bool ShowDate { get; set; } = true;
    public bool ShowNextDirection { get; set; } = true;
    public bool ShowNextDirectionArrow { get; set; } = true;
    public bool ShowNextDirectionDistance { get; set; } = true;
    public bool ShowNextStopTime { get; set; } = true;
    public bool ShowNextStopAddress { get; set; } = true;
    public bool ShowNextStopPickupDropoff { get; set; } = true;
    public bool ShowStudentsOnBus { get; set; } = true;
    public bool ShowStudentScans { get; set; }
    public bool StudentScanAudibleAlert { get; set; }

    // Navigation features
    public bool AudibleDirections { get; set; }
    public bool EarlyDisengage { get; set; }
    public int EarlyDisengageDistance { get; set; } = 500;
    public bool EarlyDisengageKeepOff { get; set; }
}
