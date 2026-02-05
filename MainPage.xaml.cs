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
                lblDisplay.Text = "Break timer is over!";
                if (isRunning)
                {
                    isRunning = false;
                    ftmMain.Background = Colors.Red;
                }
                else
                {
                    isRunning = true;
                    ftmMain.Background = Colors.White
                }
               
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