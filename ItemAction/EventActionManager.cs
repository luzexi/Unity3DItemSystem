using System;
using System.Collections.Generic;
using UnityEngine;


//  EventActionManager.cs
//  Author: Lu Zexi
//  2013-12-24



/// <summary>
/// event action manager
/// </summary>
public class EventActionManager
{
    private static EventActionManager m_sInstance;
    public static EventActionManager sIntance
    {
        if(m_sInstance == null)
            m_sInstance = new EventActionManager();
        return m_sInstance;
    }

    private Dictionary<int, EventAction> m_mapEvent = new Dictionary<int, EventAction>();   //event set

    public EventActionManager()
    {
        //
    }

	//excute action
    public ActionError Excute(int id, ActionInput input)
    {
        if (this.m_mapEvent.ContainsKey(id))
        {
            EventAction ev = this.m_mapEvent[id];
			return ev.Excute(input);
		}
        return ActionError.NoError;
	}

	//excute require
    public ActionError ExcuteReq(int id, ActionInput input)
    {
        if (this.m_mapEvent.ContainsKey(id))
        {
			EventAction ev = this.m_mapEvent[id];
			return ev.Require(input);
		}
        return ActionError.NoError;
	}

    //action roll back
    public ActionError RollBack(int id, ActionInput input)
    {
        if (this.m_mapEvent.ContainsKey(id))
        {
            EventAction ev = this.m_mapEvent[id];
            return ev.RollBack(input);
        }
        return ActionError.NoError;
    }

    //add event action
    public void AddEvent( int id , EventAction ea )
    {
        if(this.m_mapEvent.ContainsKey(id))
        {
            Debug.LogWarning("Event ID is already exist. " + id);
            this.m_mapEvent[id] = ea;
            return;
        }
        this.m_mapEvent.Add(id,ea);
    }
}
