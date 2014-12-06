using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//  EquipReqActionBattleHP.cs
//  Author: Lu Zexi
//  2014-01-21




/// <summary>
/// 战斗装备需求action HP
/// </summary>
public class EquipReqActionBattleHP : CAction
{
    private float m_fHPMinRate; //HP最小百分比
    private float m_fHPMaxRate; //HP最大百分比

    public EquipReqActionBattleHP(int id, int actionType, int runType)
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

        float hpRate = hero.m_iHp * 1f / hero.m_cMaxHP.GetFinalData();

        if (hpRate >= this.m_fHPMinRate && hpRate <= this.m_fHPMaxRate)
        {
            return ACTION_ERROR_CODE.NONE;
        }

        return ACTION_ERROR_CODE.ERROR;
    }

    /// <summary>
    /// 读取文本
    /// </summary>
    /// <param name="lst"></param>
    /// <param name="index"></param>
    public override void Read(List<string> lst, ref int index)
    {
        this.m_fHPMinRate = float.Parse(lst[index++]);
        this.m_fHPMaxRate = float.Parse(lst[index++]);
    }
}
