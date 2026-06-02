namespace MTWeb.Models.TylerDrive.Setup;

public class RidershipSetupModel
{
    public bool StudentRidershipEnabled { get; set; } = true;
    public bool FlagStudentsOnWrongRun { get; set; } = true;
    public bool FlagStudentsAtWrongStop { get; set; } = true;
    public bool ShowStudentSeating { get; set; } = true;
    public bool ShowNoShows { get; set; } = true;
    public bool DsrEnabled { get; set; } = true;
    public bool EnableQrReader { get; set; } = true;
    public string CustomFields { get; set; } = string.Empty;
    public bool RequireDriverAcknowledgementOfVisualIndicators { get; set; } = true;
}
