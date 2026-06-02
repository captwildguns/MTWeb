namespace MTWeb.Models.TylerDrive.Setup;

public class AlkSetupModel
{
    // Cellular data
    public bool AllowCellularForFeedback { get; set; }
    public bool AllowCellularForGlobalUsage { get; set; }
    public bool AllowCellularForNewsAndUpdates { get; set; }
    public bool AllowCellularForMapDownloads { get; set; }
    public bool AllowCellularForSearch { get; set; }
    public bool AllowCellularForTrafficServices { get; set; }

    // Navigation display
    public int ApproachingStopDistance { get; set; } = 500;
    public string ChevronDisplay { get; set; } = "Both";
    public string FlowTrafficAvailability { get; set; } = "Automatic";
    public string StopSideDisplay { get; set; } = "Auto";
    public string TrafficBarVisibility { get; set; } = "Automatic";

    // Audio
    public bool PlayWelcome { get; set; } = true;
    public bool SayWelcome { get; set; } = true;
    public bool AudibleDirections { get; set; } = true;
    public bool SpeakCalculatingRoute { get; set; } = true;
    public bool SetSpeedAlertAudio { get; set; }

    // Navigation messages
    public bool ShowArrivalPopup { get; set; } = true;
    public string NavMessageAtStop { get; set; } = "Always";
    public string NavMessageInMotion { get; set; } = "Never";

    // Turn warnings
    public bool EnableEarlyTurnWarning { get; set; } = true;
    public bool EnableFarTurnWarning { get; set; } = true;
    public bool EnableNearTurnWarning { get; set; } = true;
    public bool EnableTurnRestrictions { get; set; } = true;
    public bool ShowTurnAfterNext { get; set; }

    // Map display
    public string NavMapViewAtStop { get; set; } = "Overview";
    public string NavMapViewInMotion { get; set; } = "Turn";
    public int MapUpdateIntervalMs { get; set; } = 1000;

    // Info bar
    public string InfoBarLeft { get; set; } = "Speed";
    public string InfoBarRight { get; set; } = "ETA";
}
