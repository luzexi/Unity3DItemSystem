using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  ReqActionBattleBuff.cs
//  Author: Lu Zexi
//  2013-12-24


/// <summary>
/// 战场BUFF需求Action
/// </summary>
public class ReqActionBattleBuff : CAction
{
    private BATTLE_BUF m_eBUFF; //BUFF

    public ReqActionBattleBuff(int id, int actionType, int runType)
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

        if (!aInput.GetBattleHero().BUFExist(this.m_eBUFF))
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
        this.m_eBUFF = (BATTLE_BUF)int.Parse(lst[index++]);
    }
}
