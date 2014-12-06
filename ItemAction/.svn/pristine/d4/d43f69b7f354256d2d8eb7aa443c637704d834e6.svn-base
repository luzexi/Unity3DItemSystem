using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  ReqActionBattleNotBuff.cs
//  Author: Lu Zexi
//  2013-12-31



/// <summary>
/// 无此BUFF 需求
/// </summary>
public class ReqActionBattleNotBuff : CAction
{
    private BATTLE_BUF m_eBuff; //无此BUFF条件

    public ReqActionBattleNotBuff(int id, int actionType, int runType)
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

        if (aInput.GetBattleHero().BUFExist(this.m_eBuff))
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
        this.m_eBuff = (BATTLE_BUF)int.Parse(lst[index++]);
    }

}
