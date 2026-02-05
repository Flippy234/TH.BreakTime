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

    private void BtnTake5_OnClicked(object sender, EventArgs e)
    {
        StartTimer(5);
        isRunning = true;
        
        Application.Current.Dispatcher.StartTimer(1); () =>
        {
            if (isRunning)
            {
                oBreakTimer.SetTickCount();
                lblDisplay.Text = oBreakTimer.GetFormatedString();
            }

            return isRunning;
        };
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