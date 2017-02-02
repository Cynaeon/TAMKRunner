using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gs_SplashScreenIn : GameState
{
    private float m_fEventTime;
    new void Start()
    {
        m_sStateName = "Splash Screen";
        base.Start();
        m_fEventTime = Time.time;
    }
    new void Update()
    {
        if (Time.time - m_fEventTime > 1.0f)
            m_gcGameStateManager.ChangeState(MainMenuIn);
    }
}