using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  EventAction.cs
//  Author: Lu zexi
//  2013-12-24



/// <summary>
/// Action event
/// </summary>
public class EventAction
{
    private int m_iID; //ID
    private int[] m_vecActions; //Action ID list
    private int[] m_vecReqActions; //Require Action ID list

    public EventAction()
    {
        this.m_vecActions = new int[8];
        this.m_vecReqActions = new int[8];
    }

    // id (0-99999) , actionType(0-99) , runType(0-99)
    public EventAction( int id , int eventType , int runType)
    {
        this.m_iID = eventType * 10000000 + runType*100000 + id;
    }

    //get id
    public int ID
    {
        get
        {
            return this.m_iID;
        }
    }

    //set action
    public void SetAction( int[] act )
    {
        this.m_vecActions = act;
    }

    //set require
    public void SetRequire( int[] req )
    {
        this.m_vecReqActions = req;
    }

    //excute action
    public ActionError Excute( ActionInput input  )
    {
        for (int i = 0; i < this.m_vecActions.Length; i++)
        {
            CAction action = ActionManager.sInstance.GetAction(this.m_vecActions[i]);
            if (action != null)
            {
                ActionError error = action.Excute(input);
                if ( error != null && error.code != ACTION_ERROR_CODE.NONE)
                    return error;
            }
        }
        return ActionError.NoError;
    }

    //action require
    public ActionError Require( ActionInput input)
    {
        for (int i = 0; i < this.m_vecReqActions.Length; i++)
        {
            CAction action = ActionManager.sInstance.GetAction(this.m_vecReqActions[i]);
            if (action != null)
            {
                ActionError error = action.Excute(input);
                if ( error != null && error.code != ACTION_ERROR_CODE.NONE)
                    return error;
            }
        }
        return ActionError.NoError;
    }

    //action roll back
    public ActionError RollBack(ActionInput input)
    {
        for (int i = 0; i < this.m_vecActions.Length; i++)
        {
            CAction action = ActionManager.sInstance.GetAction(this.m_vecActions[i]);
            if (action != null)
            {
                ActionError error = action.RollBack(input);
                if (error != null && error.code != ACTION_ERROR_CODE.NONE)
                    return error;
            }
        }
        return ActionError.NoError;
    }
}
