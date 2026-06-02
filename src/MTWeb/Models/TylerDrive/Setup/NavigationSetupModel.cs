namespace MTWeb.Models.TylerDrive.Setup;

public class NavigationSetupModel
{
    // Basic navigation
    public bool EnableTodaysRuns { get; set; } = true;
    public bool EnableStartNavigation { get; set; } = true;
    public bool AllowTrips { get; set; }
    public bool ShowNextStopEta { get; set; }
    public bool RequireTripCompletionData { get; set; }
    public bool RequireRunSignature { get; set; }

    // Auto rollout
    public bool EnableAutoRollout { get; set; }

    // AVL
    public bool EnableAvl { get; set; }
    public bool EventOnlyAvl { get; set; }
    public int AvlIntervalSeconds { get; set; } = 30;
    public int AvlStopIntervalSeconds { get; set; } = 10;
    public int AvlEarlyAlertMinutes { get; set; } = 5;
    public int AvlLateAlertMinutes { get; set; } = 5;
    public int StopArrivalThresholdFeet { get; set; } = 100;
    public bool ShowStopOnTime { get; set; }

    // Road Along
    public bool RoadAlongAllStops { get; set; } = true;
    public bool RoadAlongCurbToCurb { get; set; }
    public int RoadAlongStreetBufferFeet { get; set; } = 50;
    public int RoadAlongBeforeBufferFeet { get; set; } = 50;
    public int RoadAlongAfterBufferFeet { get; set; } = 50;

    // Speed
    public int SpeedingBufferMph { get; set; } = 5;

    // Modify stops
    public bool ModifyStopsRequirePlannedRoute { get; set; }
    public bool AllowModifyStopsDuringNavigation { get; set; }

    // ETA notifications
    public bool EnableEtaNotifications { get; set; }
}
