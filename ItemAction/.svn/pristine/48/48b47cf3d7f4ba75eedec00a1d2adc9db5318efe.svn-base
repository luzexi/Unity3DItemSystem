using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  CAction.cs
//  Author: Lu Zexi
//  2013-12-24



/// <summary>
/// Action基类
/// </summary>
public abstract class CAction : IAction
{
    private int m_iID;  //唯一ID
    private int m_iActionType;    //类型
    private int m_iRunType; //运行时类型

    public CAction(int id, int actionType, int runType)
    {
        this.m_iID = id;
        this.m_iActionType = actionType;
        this.m_iRunType = runType;
    }

    public abstract ACTION_ERROR_CODE Excute(ActionInput input);

    /// <summary>
    /// 回滚
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public virtual ACTION_ERROR_CODE RollBack(ActionInput input)
    {
        return ACTION_ERROR_CODE.NONE;
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
    /// 获取Action类型
    /// </summary>
    /// <returns></returns>
    public int GetActionType()
    {
        return this.m_iActionType;
    }

    /// <summary>
    /// 获取运行时类型
    /// </summary>
    /// <returns></returns>
    public int GetRunType()
    {
        return this.m_iRunType;
    }

    /// <summary>
    /// 读取数据
    /// </summary>
    /// <param name="lst"></param>
    /// <param name="index"></param>
    public virtual void Read(List<string> lst, ref int index)
    {
        //
    }
}
