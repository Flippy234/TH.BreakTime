
namespace BreakTime.Custom;

public class BreakTimeLogic
{
    private int _intSec;
    private int _intMin;

    public BreakTimeLogic()
    {
        Reset();
    }

    public void Reset()
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
            if (_intMin > 0)
            {
                _intMin--;
                _intSec = 59;
            }
        }
        else
        {
            _intSec--;
        }
    }

    public bool IsTimeUp()
    {
        return _intMin == 0 && _intSec == 0;
    }


    public string GetFormattedString()
    {
        return $"{_intMin:00}:{_intSec:00} Minutes Left";
    }
}