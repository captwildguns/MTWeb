namespace MTWeb.Models.TylerDrive.Setup;

public class MessagingSetupModel
{
    public string MessagingMode { get; set; } = "Off";
    public int DaysOfHistory { get; set; } = 7;
    public bool AllowCannedResponses { get; set; }
    public bool AllowKeyboardResponses { get; set; }
    public List<CannedResponseModel> CannedResponses { get; set; } = [];
}
