namespace MTWeb.Models.TylerDrive.Setup;

public class MessagingSetupModel
{
    public string MessagingMode { get; set; } = "Off";
    public int DaysOfHistory { get; set; } = 7;
    public bool AllowKeyboard { get; set; } = true;
    public bool AllowCanned { get; set; } = true;
    public List<CannedResponseModel> CannedResponses { get; set; } = [];
}
