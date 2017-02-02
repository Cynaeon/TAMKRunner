using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameState : MonoBehaviour
{
    protected string m_sStateName = "BaseClass";
    protected GameStateManager m_gcGameStateManager;
    protected GameGlobals m_gcGameGlobals;

    virtual public void Start()
    {
        Debug.Log("GameState: " + m_sStateName + "\n");
        m_gcGameGlobals = GameGlobals.Instance;
        m_gcGameStateManager = m_gcGameGlobals.m_gcGameStateManager;
    }

    virtual public void Update()
    {
    }
    virtual public void OnDisable()
    {
        Debug.Log("Exiting game state...\n");
    }
}
