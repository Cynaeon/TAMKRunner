using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour {

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(m_goGameState);
        SetState(GameState.tStateType._SplashScreenIn);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangeState(GameState.tStateType iState, string sLevelName = "")
    {
        Destroy(m_goGameState);
        m_goGameState = new GameObject();
        DontDestroyOnLoad(m_goGameState); // Never destroy...
        if (sLevelName != "")
        {
            m_bWaitingForLoad = true;
            m_iNewState = iState;
            SceneManager.LoadScene(sLevelName);
        }
        else
            SetState(iState);
    }

    private void SetState(GameState.tStateType iState)
    {
        switch (iState)
        {
            case GameState.tStateType._SplashScreenIn:
                m_goGameState.AddComponent<gs_SplashScreenIn>();
                m_goGameState.name = "GS: Splash Screen";
                break;
            case GameState.tStateType._MainMenuIn:
                m_goGameState.AddComponent<gs_MainMenuIn>();
                m_goGameState.name = "GS: Main Menu";
                break;
                Etc.
        }
        m_iNewState = GameState.tStateType._NULL;
        m_bWaitingForLoad = false;
    }
}
