using Assets.State;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private BattleState m_battleState;
    private BattleState battleState
    {
        get
        {
            if (m_battleState == null)
                m_battleState = new BattleState();
            return m_battleState;
        }
    }

    private PrepareState m_prepareState;
    private PrepareState prepareState
    {
        get
        {
            if (m_prepareState == null)
                m_prepareState = new PrepareState();
            return m_prepareState;
        }
    }

    private BeforeBattleState m_beforeState;
    private BeforeBattleState beforeState
    {
        get
        {
            if (m_beforeState == null)
                m_beforeState = new BeforeBattleState();
            return m_beforeState;
        }
    }

    private BaseGameState curState;
    // Start is called before the first frame update
    void Start()
    {
        curState = prepareState;
        curState.Enter();
    }

    // Update is called once per frame
    void Update()
    {
        curState.Execute();
        if(!curState.CheckIsAlive())
        {
            curState.Exit();
            curState = GetNextState();
            curState.Enter();
        }
        RefreshUI();
    }

    void RefreshUI()
    {

    }

    BaseGameState GetNextState()
    {
        if (curState.GetType().Equals(typeof(PrepareState)))
            return beforeState;
        else if (curState.GetType().Equals(typeof(BeforeBattleState)))
            return battleState;
        else
            return prepareState;
            
    }
}
