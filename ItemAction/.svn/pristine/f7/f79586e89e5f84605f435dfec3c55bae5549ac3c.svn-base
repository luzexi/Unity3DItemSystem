using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  EventAction.cs
//  Author: Lu zexi
//  2013-12-24



/// <summary>
/// Action事件
/// </summary>
public class EventAction
{
    private int m_iID; // ID
    private int[] m_vecActions; // ActionID列表
    private int[] m_vecReqActions; // 需求ActionID

    public EventAction()
    {
        this.m_vecActions = new int[8];
        this.m_vecReqActions = new int[8];
    }

    /// <summary>
    /// 获取ID
    /// </summary>
    /// <returns></returns>
    public int GetID()
    {
        return this.m_iID;
    }

    /// <summary>
    /// 执行action
    /// </summary>
    /// <returns></returns>
    public ACTION_ERROR_CODE Excute( ActionInput input  )
    {
        for (int i = 0; i < this.m_vecActions.Length; i++)
        {
            CAction action = ActionManager.GetInstance().GetAction(this.m_vecActions[i]);
            if (action != null)
            {
                ACTION_ERROR_CODE code = action.Excute(input);
                if (code != ACTION_ERROR_CODE.NONE)
                    return code;
            }
        }
        return ACTION_ERROR_CODE.NONE;
    }

    /// <summary>
    /// 需求action
    /// </summary>
    /// <returns></returns>
    public ACTION_ERROR_CODE Require( ActionInput input)
    {
        for (int i = 0; i < this.m_vecReqActions.Length; i++)
        {
            CAction action = ActionManager.GetInstance().GetAction(this.m_vecReqActions[i]);
            if (action != null)
            {
                ACTION_ERROR_CODE code = action.Excute(input);
                if (code != ACTION_ERROR_CODE.NONE)
                    return code;
            }
        }
        return ACTION_ERROR_CODE.NONE;
    }

    /// <summary>
    /// 回滚
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public ACTION_ERROR_CODE RollBack(ActionInput input)
    {
        for (int i = 0; i < this.m_vecActions.Length; i++)
        {
            CAction action = ActionManager.GetInstance().GetAction(this.m_vecActions[i]);
            if (action != null)
            {
                ACTION_ERROR_CODE code = action.RollBack(input);
                if (code != ACTION_ERROR_CODE.NONE)
                    return code;
            }
        }
        return ACTION_ERROR_CODE.NONE;
    }


    /// <summary>
    /// 读取数据
    /// </summary>
    /// <param name="lst"></param>
    /// <param name="index"></param>
    public void Read(List<string> lst, ref int index)
    {
        this.m_iID = int.Parse(lst[index++]);
        string desc = lst[index++];
        for (int i = 0; i < this.m_vecReqActions.Length; i++)
        {
            this.m_vecReqActions[i] = int.Parse(lst[index++]);
        }
        for (int i = 0; i < this.m_vecActions.Length; i++)
        {
            this.m_vecActions[i] = int.Parse(lst[index++]);
        }
    }
}
