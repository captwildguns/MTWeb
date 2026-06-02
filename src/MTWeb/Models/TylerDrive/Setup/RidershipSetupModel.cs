namespace MTWeb.Models.TylerDrive.Setup;

public class RidershipSetupModel
{
    public bool EnableStudentRidership { get; set; }
    public int ActiveStudentThreshold { get; set; } = 0;
    public bool FlagStudentsRun { get; set; }
    public bool FlagStudentsStop { get; set; }
    public bool ShowStudentSeating { get; set; }
    public bool ShowNoShows { get; set; }
    public bool EnableDsr { get; set; }
    public bool RequireVisualIndicatorAcknowledgement { get; set; }
    public bool EnableQrReader { get; set; }
}
