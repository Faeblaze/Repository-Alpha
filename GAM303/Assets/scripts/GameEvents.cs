using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class GameEvents   
{
    //declaring the events
    public static event Action<int> OnScoreChange = null;

    //event reporting
    public static void ReportOnScoreChange(int newValue)
    {
        if (OnScoreChange != null)
            OnScoreChange(newValue);
    }
}
