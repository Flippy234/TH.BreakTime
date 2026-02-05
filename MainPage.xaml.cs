using BreakTime.Custom;
namespace BreakTime;

public partial class MainPage : ContentPage
{
    private BreakTimeLogic oBreakTimer = new BreakTimeLogic();
    private bool isRunning = false;
    private bool isFlickering = false;
    
    
    public MainPage()
    {
        InitializeComponent();
        Title = "Break Time";
    }


    private void StartTimer(int minutes)
    {
        isRunning = false;
        isFlickering = false;
        ftmMain.Background = Colors.White;
        
        oBreakTimer.SetBreakMinutes(minutes);
        lblDisplay.Text = oBreakTimer.GetFormattedString();
        isRunning = true;
        
        Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            if (!isRunning)
                return false;

            oBreakTimer.SetTickCount();
            lblDisplay.Text = oBreakTimer.GetFormattedString();

            if (oBreakTimer.IsTimeUp())
            {
                isRunning = false;
                lblDisplay.Text = "Break time is over!";

                ftmMain.Background = Colors.Red;
                return false;
            }
            
            return true;
        });
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