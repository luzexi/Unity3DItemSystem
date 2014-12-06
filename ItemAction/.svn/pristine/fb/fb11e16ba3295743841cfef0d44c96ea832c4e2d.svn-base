using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  ReqActionBattleBuffs.cs
//  Author: Lu Zexi
//  2013-12-26



/// <summary>
/// 战场多BUFF或条件
/// </summary>
public class ReqActionBattleBuffs : CAction
{
    private BATTLE_BUF[] m_vecBuff;

    public ReqActionBattleBuffs(int id, int actionType, int runType)
        : base(id, actionType, runType)
    {
        this.m_vecBuff = new BATTLE_BUF[3];
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

        for (int i = 0; i < this.m_vecBuff.Length; i++)
        {
            if (aInput.GetBattleHero().BUFExist(this.m_vecBuff[i]))
                return ACTION_ERROR_CODE.NONE;
        }

        return ACTION_ERROR_CODE.ERROR;
    }

    /// <summary>
    /// 读取数据
    /// </summary>
    /// <param name="lst"></param>
    /// <param name="index"></param>
    public override void Read(List<string> lst, ref int index)
    {
        for (int i = 0; i < this.m_vecBuff.Length; i++)
        {
            this.m_vecBuff[i] = (BATTLE_BUF)(int.Parse(lst[index++]));
        }
    }

}
