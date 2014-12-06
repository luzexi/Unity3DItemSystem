using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  ReqActionBattleBBFull.cs
//  Author: Lu Zexi
//  2013-12-26




/// <summary>
/// BB槽是否满条件
/// </summary>
public class ReqActionBattleBBFull : CAction
{
    private bool m_bFull;   //是否满

    public ReqActionBattleBBFull(int id, int actionType, int runType)
        :base(id , actionType , runType)
    { 

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

        if ((aInput.GetBattleHero().m_fBBHP >= aInput.GetBattleHero().m_iBBMaxHP && aInput.GetBattleHero().m_iBBMaxHP > 0 ) != this.m_bFull)
        {
            return ACTION_ERROR_CODE.ERROR;
        }

        return ACTION_ERROR_CODE.NONE;
    }

    /// <summary>
    /// 读取数据
    /// </summary>
    /// <param name="lst"></param>
    /// <param name="index"></param>
    public override void Read(List<string> lst, ref int index)
    {
        this.m_bFull = bool.Parse(lst[index++]);
    }
}
