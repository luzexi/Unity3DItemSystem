using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  ReqActionBattleDead.cs
//  Author: Lu Zexi
//  2013-12-25



/// <summary>
/// 战场死亡需求Action
/// </summary>
public class ReqActionBattleDead : CAction
{
    private bool m_bLive;   //是否活的需求

    public ReqActionBattleDead(int id, int actionType, int runType)
        : base(id, actionType, runType)
    { 
        //
    }

    /// <summary>
    /// 执行
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public override ACTION_ERROR_CODE Excute(ActionInput input)
    {
        BattleHeroActionInput aInput = (BattleHeroActionInput)input;

        if (aInput.GetBattleHero() == null)
            return ACTION_ERROR_CODE.ERROR;

        if (aInput.GetBattleHero().m_bDead == m_bLive)
            return ACTION_ERROR_CODE.ERROR;

        return ACTION_ERROR_CODE.NONE;
    }

    /// <summary>
    /// 读取数据
    /// </summary>
    /// <param name="lst"></param>
    /// <param name="index"></param>
    public override void Read(List<string> lst, ref int index)
    {
        this.m_bLive = bool.Parse(lst[index++]);
    }
}
