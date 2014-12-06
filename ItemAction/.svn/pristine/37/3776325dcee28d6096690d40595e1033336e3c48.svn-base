using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  EquipActionBattleAddBase.cs
//  Author: Lu Zexi
//  2014-01-21



/// <summary>
/// 战斗装备action 增加攻击，防御，回复，最大HP 属性
/// </summary>
public class EquipActionBattleAddBase : CAction
{
    private float m_fAttackRateInc; //攻击增加比率
    private float m_fDefenceRateInc;    //防御增加比率
    private float m_fRecoverRateInc;    //回复增加比率
    private float m_fMaxHPRateInc;  //最大HP增加比率

    public EquipActionBattleAddBase(int id, int actionType, int runType)
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

        hero.m_cAttack.AddRate(this.m_fAttackRateInc);
        hero.m_cDefence.AddRate(this.m_fDefenceRateInc);
        hero.m_cRecover.AddRate(this.m_fRecoverRateInc);
        hero.m_cMaxHP.AddRate(this.m_fMaxHPRateInc);

        return ACTION_ERROR_CODE.NONE;
    }

    /// <summary>
    /// 回滚
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public override ACTION_ERROR_CODE RollBack(ActionInput input)
    {
        BattleHeroEquipActionInput aInput = (BattleHeroEquipActionInput)input;

        BattleHero hero = aInput.GetBattleHero();

        hero.m_cAttack.RemoveRate(this.m_fAttackRateInc);
        hero.m_cDefence.RemoveRate(this.m_fDefenceRateInc);
        hero.m_cRecover.RemoveRate(this.m_fRecoverRateInc);
        hero.m_cMaxHP.RemoveRate(this.m_fMaxHPRateInc);

        return ACTION_ERROR_CODE.NONE;
    }

    /// <summary>
    /// 读取数据
    /// </summary>
    /// <param name="lst"></param>
    /// <param name="index"></param>
    public override void Read(List<string> lst, ref int index)
    {
        this.m_fAttackRateInc = float.Parse(lst[index++]);
        this.m_fDefenceRateInc = float.Parse(lst[index++]);
        this.m_fRecoverRateInc = float.Parse(lst[index++]);
        this.m_fMaxHPRateInc = float.Parse(lst[index++]);
    }

}
