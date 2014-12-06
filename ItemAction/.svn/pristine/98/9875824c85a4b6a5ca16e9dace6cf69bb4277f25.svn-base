using System;
using System.Collections.Generic;
using Game.Base;
using Game.Resource;
using UnityEngine;


//  ActionManager.cs
//  Author: Lu Zexi
//  2013-12-24



/// <summary>
/// Action管理类
/// </summary>
public class ActionManager : Singleton<ActionManager>
{
    private Dictionary<int, CAction> m_mapAction = new Dictionary<int, CAction>();  //action集合

    public ActionManager()
    {
#if GAME_TEST_LOAD
        LoadText(ResourcesManager.GetInstance().Load(GAME_DEFINE.RESOURCE_TABLE_PATH, TABLE_DEFINE.ITEM_ACTION) as string);
#endif
    }

    /// <summary>
    /// 获取Action
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public CAction GetAction(int id)
    {
        if (this.m_mapAction.ContainsKey(id))
            return this.m_mapAction[id];
        return null;
    }

    /// <summary>
    /// 增加Action
    /// </summary>
    /// <param name="id"></param>
    /// <param name="action"></param>
    public void AddAction(int id, CAction action)
    {
        this.m_mapAction.Add(id, action);
    }

    /// <summary>
    /// 加载文本数据
    /// </summary>
    public void LoadText( string content )
    {
        List<string> lst = TABLE_READER.LOAD_CSV(content);
        lst = TABLE_READER.SPLIT_EMPTY(lst);
        this.m_mapAction.Clear();
        int index = 0;
        for (; index < lst.Count; )
        {
            int id = int.Parse(lst[index++]);
            string desc = lst[index++];
            int actionType = int.Parse(lst[index++]);
            int runType = int.Parse(lst[index++]);
            CAction action = ActionFactory.Create(id, actionType, runType);
            action.Read(lst, ref index);
            AddAction(id, action);
        }
    }
}
