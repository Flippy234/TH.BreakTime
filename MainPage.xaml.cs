using BreakTime.Custom;
namespace BreakTime;

public partial class MainPage : ContentPage
{
    private BreakTimeLogic oBreakTimer = new BreakTimeLogic();
    private bool isRunning = false;
    
    
    public MainPage()
    {
        InitializeComponent();
        Title = "Break Time";
    }


    private void StartTimer(int minutes)
    {
        isRunning = false;
        
        oBreakTimer.SetBreakMinutes(minutes);
        lblDisplay.Text = oBreakTimer.GetFormattedString();
    }
    private void BtnTake5_OnClicked(object sender, EventArgs e)
    {
        StartTimer(5);
    }

    private void BtnTake10_OnClicked(object sender, EventArgs e)
    {
        StartTimer(10);
    }

    private void BtnTake15_OnClicked(object sender, EventArgs e)
    {
        StartTimer(15);
    }
    
    
}