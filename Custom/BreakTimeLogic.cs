using Android.App.Admin;

namespace BreakTime.Custom;

public class BreakTimeLogic
{
    private int _intSec;
    private int _intMin;
}

public BreakTimeLogic()
{
    Reset();
}

public void Reset()
{
    _intSec = 0;
    _intMin = 0;
}

public void SetTickCount()
{
    _intSec++;
    if (_intSec == 60)
    {
        intMin++;
    }
}

public string GetFormattedString()
{
    return _intMins.ToString().PadLeft(2, '0') + "" + "Minutes Left";
}