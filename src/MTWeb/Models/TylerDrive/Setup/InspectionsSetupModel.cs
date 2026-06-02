namespace MTWeb.Models.TylerDrive.Setup;

public class InspectionsSetupModel
{
    public bool FieldInspectionsEnabled { get; set; } = true;
    public bool SignatureOnFail { get; set; }
    public bool SignatureOnPass { get; set; }
    public bool UpdateOdometer { get; set; } = true;
    public bool SingleDefectSelection { get; set; }
    public bool EnableWorkOrderVerification { get; set; }
    public bool HideVehiclesWithOpenWorkOrders { get; set; }
    public string NotesOnFail { get; set; } = "Off";
    public string NotesOnCritical { get; set; } = "Off";
    public bool OdometerWarningEnabled { get; set; }
    public int OdometerWarningThreshold { get; set; } = 2;
    public int OdometerWarningMinimumUnits { get; set; } = 50;
}
