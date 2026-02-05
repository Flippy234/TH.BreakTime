
namespace BreakTime.Custom;

public class BreakTimeLogic
{
    private int _intSec;
    private int _intMin;

    public BreakTimeLogic()
    {
        Reset();
    }

    private void Reset()
    {
        _intSec = 0;
        _intMin = 0;
    }

    public void SetBreakMinutes(int minutes)
    {
        _intMin = minutes;
        _intSec = 0;
    }

    public void SetTickCount()
    {
        if (_intMin == 0 && _intSec == 0)
            return;
        if (_intSec == 0)
        {
            _intSec--;
            _intSec = 59;
        }
        else
        {
            _intSec--;
        }
    }


    public string GetFormattedString()
    {
        return _intMin.ToString().PadLeft(2, '0') + _intSec.ToString().left" Minutes Left");
    }
}