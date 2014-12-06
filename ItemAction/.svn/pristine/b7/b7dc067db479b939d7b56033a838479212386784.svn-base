using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



//  ReqActionBattleNature.cs
//  Author: Lu Zexi
//  2013-12-24


/// <summary>
/// 战场属性需求Action
/// </summary>
public class ReqActionBattleNature : CAction
{
    private Nature m_eNature;   //属性

    public ReqActionBattleNature(int id, int actionType, int runType)
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

        if (aInput.GetBattleHero().m_eNature != this.m_eNature)
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
        this.m_eNature = (Nature)int.Parse(lst[index++]);
    }
}
