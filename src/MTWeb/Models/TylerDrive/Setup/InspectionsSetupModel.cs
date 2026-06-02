namespace MTWeb.Models.TylerDrive.Setup;

public class InspectionsSetupModel
{
    public bool EnableFieldInspections { get; set; }
    public bool SignatureOnFail { get; set; }
    public bool SignatureOnPass { get; set; }
    public bool UpdateOdometer { get; set; }
    public bool NotesOnFail { get; set; }
    public bool NotesOnCritical { get; set; }
    public bool EnforceSingleDefect { get; set; }
    public bool EnableWorkOrderVerification { get; set; }
    public bool HideVehiclesWithOpenWorkOrders { get; set; }
    public bool EnableOdometerWarning { get; set; }
    public int OdometerWarningThreshold { get; set; } = 2;
    public int OdometerWarningMinimumUnits { get; set; } = 50;
}
