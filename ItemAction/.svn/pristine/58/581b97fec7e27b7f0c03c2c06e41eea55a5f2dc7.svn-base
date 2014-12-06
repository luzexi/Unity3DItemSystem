using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  ActionBattleAddAllBUFF.cs
//  Author: Lu Zexi
//  2013-12-30



/// <summary>
/// 战斗增加全体BUFF Action
/// </summary>
public class ActionBattleAddAllBUFF : CAction
{
    private Nature m_eNature;    //对应属性
    private BATTLE_BUF m_eBUFF; //BUFF
    private int m_iRound;   //回合数
    private float m_fArg;   //BUFF参数

    public ActionBattleAddAllBUFF(int id, int actionType, int runType)
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

        if (aInput.GetBattleAllHero() == null)
            return ACTION_ERROR_CODE.ERROR;

        foreach (BattleHero item in aInput.GetBattleAllHero())
        {
            if (item != null && !item.m_bDead && item.m_eNature != Nature.None && item.m_eNature == this.m_eNature)
            {
                item.BUFAdd(this.m_eBUFF, this.m_iRound, this.m_fArg);
            }
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
        this.m_eNature = (Nature)int.Parse(lst[index++]);
        this.m_eBUFF = (BATTLE_BUF)int.Parse(lst[index++]);
        this.m_iRound = int.Parse(lst[index++]);
        this.m_fArg = float.Parse(lst[index++]);
    }
}
