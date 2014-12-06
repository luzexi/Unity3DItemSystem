using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



//  EquipReqActionBattleExcuteNum.cs
//  Author: Lu Zexi
//  2014-01-22



/// <summary>
/// 战斗装备action 执行次数需求
/// </summary>
public class EquipReqActionBattleExcuteNum : CAction
{
    private int m_iExNum;   //执行次数

    public EquipReqActionBattleExcuteNum(int id, int actionType, int runType)
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
        BattleHeroEquipActionInput aInput = (BattleHeroEquipActionInput)input;

        BattleHero hero = aInput.GetBattleHero();

        if (this.m_iExNum <= 0)
            return ACTION_ERROR_CODE.NONE;

        if (hero.m_iEquipActionNum < this.m_iExNum)
            return ACTION_ERROR_CODE.NONE;

        return ACTION_ERROR_CODE.ERROR_EXU_NUM;
    }

    /// <summary>
    /// 读取数据
    /// </summary>
    /// <param name="lst"></param>
    /// <param name="index"></param>
    public override void Read(List<string> lst, ref int index)
    {
        this.m_iExNum = int.Parse(lst[index++]);
    }
}

