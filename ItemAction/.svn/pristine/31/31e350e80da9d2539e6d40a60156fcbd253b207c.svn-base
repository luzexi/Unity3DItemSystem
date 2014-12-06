using System;
using System.Collections.Generic;
using Game.Base;
using Game.Resource;
using UnityEngine;


//  EventActionManager.cs
//  Author: Lu Zexi
//  2013-12-24



/// <summary>
/// 事件管理
/// </summary>
public class EventActionManager : Singleton<EventActionManager>
{
    private Dictionary<int, EventAction> m_mapEvent = new Dictionary<int, EventAction>();   //事件Action集合

    public EventActionManager()
    {
#if GAME_TEST_LOAD
        LoadText(ResourcesManager.GetInstance().Load(GAME_DEFINE.RESOURCE_TABLE_PATH, TABLE_DEFINE.ITEM_EVENT_ACTION) as string);
#endif
    }

	// 执行Action
    public ACTION_ERROR_CODE Excute(int id, ActionInput input)
    {
        if (this.m_mapEvent.ContainsKey(id))
        {
            EventAction ev = this.m_mapEvent[id];
			return ev.Excute(input);
		}
        return ACTION_ERROR_CODE.NONE;
	}

	// 执行需求Action
    public ACTION_ERROR_CODE ExcuteReq(int id, ActionInput input)
    {
        if (this.m_mapEvent.ContainsKey(id))
        {
			EventAction ev = this.m_mapEvent[id];
			return ev.Require(input);
		}
        return ACTION_ERROR_CODE.NONE;
	}

    /// <summary>
    /// 回滚
    /// </summary>
    /// <param name="id"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    public ACTION_ERROR_CODE RollBack(int id, ActionInput input)
    {
        if (this.m_mapEvent.ContainsKey(id))
        {
            EventAction ev = this.m_mapEvent[id];
            return ev.RollBack(input);
        }
        return ACTION_ERROR_CODE.NONE;
    }

    /// <summary>
    /// 读取文本数据
    /// </summary>
    /// <param name="content"></param>
	public void LoadText( string content)
    {
        List<string> lst = TABLE_READER.LOAD_CSV(content);
        lst = TABLE_READER.SPLIT_EMPTY(lst);
        int index = 0;

        this.m_mapEvent.Clear();

        for (; index < lst.Count; )
        {
            EventAction ev = new EventAction();
            ev.Read(lst, ref index);
            this.m_mapEvent.Add(ev.GetID(), ev);
        }
	}
}
