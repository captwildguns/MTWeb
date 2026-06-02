namespace MTWeb.Models.TylerDrive.Setup;

public class NavigationSetupModel
{
    // My Runs
    public bool MyRunsEnabled { get; set; } = true;
    public bool NavigationEnabled { get; set; } = true;
    public bool ShowNextStopEta { get; set; } = true;
    public bool AllowTrips { get; set; } = true;
    public bool CaptureTripCompletionData { get; set; } = true;
    public bool RequireEndOfRunSignature { get; set; } = true;
    public bool AutoRolloutEnabled { get; set; } = true;
    public string AddRunSearchType { get; set; } = "Both";

    // AVL
    public bool AvlEnabled { get; set; } = true;
    public bool AvlEventsOnly { get; set; }
    public int AvlStopEventIntervalSeconds { get; set; } = 10;
    public int SpeedingBufferMph { get; set; }
    public int LateAlertThresholdMinutes { get; set; }
    public int EarlyAlertThresholdMinutes { get; set; }

    // Modify Stops
    public bool ModifyStopsRequirePlannedRoute { get; set; }
    public bool ModifyStopsAllowDuringNavigation { get; set; } = true;
    public bool ModifyStopsEnableAddByAddress { get; set; } = true;

    // Additional Stop Buffer
    public bool AdditionalStopBufferAllStops { get; set; } = true;
    public int AdditionalStopBufferBeforeFeet { get; set; } = 400;
    public int AdditionalStopBufferAfterFeet { get; set; } = 400;
    public int AdditionalStopBufferFromRoadFeet { get; set; } = 20;

    // ETA
    public bool EnableEtaSystemNotifications { get; set; } = true;
}
