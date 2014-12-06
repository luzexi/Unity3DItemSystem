using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  EquipActionBattleIncExRate.cs
//  Author: Lu Zexi
//  2014-02-12




/// <summary>
/// 增加战斗参数比率
/// </summary>
public class EquipActionBattleIncExRate : CAction
{
    private float m_fMissRate;   //回避概率
    private float m_fDecHurtRate;   //减少伤害概率
    private float m_fDecHurtRateArg;   //减少伤害比率
    private float m_fAbsorbDamageRate;  //吸血概率
    private float m_fAbsorbDamageRateArg;   //吸血比率
    private float m_fReboundRate;   //伤害反弹概率
    private float m_fReboundRateArg;    //伤害反弹比率
    private float m_fRecoverHurtRate;    //伤害回复概率
    private float m_fRecoverHurtRateArg;    //伤害回复概率比率
    private float m_fRecoverHurtRateArgEx;  //伤害回复系数
    private float m_fHurtIncBBHPRate;   //受伤时增加BB槽概率
    private float m_fHurtIncBBHP;   //受伤时增加BB槽的值

    public EquipActionBattleIncExRate(int id, int actionType, int runType)
        : base(id, actionType, runType)
    {
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

        hero.m_cMissDefenceRate.AddValue(this.m_fMissRate);
        hero.m_cDecHurtRate.AddValue(this.m_fDecHurtRate);
        hero.m_cDecHurtRateArg.AddValue(this.m_fDecHurtRateArg);
        hero.m_cAbsorbDamageRate.AddValue(this.m_fAbsorbDamageRate);
        hero.m_cAbsorbDamageRateArg.AddValue(this.m_fAbsorbDamageRateArg);
        hero.m_cReboundRate.AddValue(this.m_fReboundRate);
        hero.m_cReboundRateArg.AddValue(this.m_fReboundRateArg);
        hero.m_cRecoverHurtRate.AddValue(this.m_fRecoverHurtRate);
        hero.m_cRecoverHurtRateArg.AddValue(this.m_fRecoverHurtRateArg);
        hero.m_cRecoverHurtRateArgEx.AddValue(this.m_fRecoverHurtRateArgEx);
        hero.m_cHurtIncBBHPRate.AddValue(this.m_fHurtIncBBHPRate);
        hero.m_cHurtIncBBHP.AddValue(this.m_fHurtIncBBHP);

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

        hero.m_cMissDefenceRate.RemoveValue(this.m_fMissRate);
        hero.m_cDecHurtRate.RemoveValue(this.m_fDecHurtRate);
        hero.m_cDecHurtRateArg.RemoveValue(this.m_fDecHurtRateArg);
        hero.m_cAbsorbDamageRate.RemoveValue(this.m_fAbsorbDamageRate);
        hero.m_cAbsorbDamageRateArg.RemoveValue(this.m_fAbsorbDamageRateArg);
        hero.m_cReboundRate.RemoveValue(this.m_fReboundRate);
        hero.m_cReboundRateArg.RemoveValue(this.m_fReboundRateArg);
        hero.m_cRecoverHurtRate.RemoveValue(this.m_fRecoverHurtRate);
        hero.m_cRecoverHurtRateArg.RemoveValue(this.m_fRecoverHurtRateArg);
        hero.m_cRecoverHurtRateArgEx.RemoveValue(this.m_fRecoverHurtRateArgEx);
        hero.m_cHurtIncBBHPRate.RemoveValue(this.m_fHurtIncBBHPRate);
        hero.m_cHurtIncBBHP.RemoveValue(this.m_fHurtIncBBHP);

        return ACTION_ERROR_CODE.NONE;
    }

    /// <summary>
    /// 读取数据
    /// </summary>
    /// <param name="lst"></param>
    /// <param name="index"></param>
    public override void Read(List<string> lst, ref int index)
    {
        this.m_fMissRate = float.Parse(lst[index++]);
        this.m_fDecHurtRate = float.Parse(lst[index++]);
        this.m_fDecHurtRateArg = float.Parse(lst[index++]);
        this.m_fAbsorbDamageRate = float.Parse(lst[index++]);
        this.m_fAbsorbDamageRateArg = float.Parse(lst[index++]);
        this.m_fReboundRate = float.Parse(lst[index++]);
        this.m_fReboundRateArg = float.Parse(lst[index++]);
        this.m_fRecoverHurtRate = float.Parse(lst[index++]);
        this.m_fRecoverHurtRateArg = float.Parse(lst[index++]);
        this.m_fRecoverHurtRateArgEx = float.Parse(lst[index++]);
        this.m_fHurtIncBBHPRate = float.Parse(lst[index++]);
        this.m_fHurtIncBBHP = float.Parse(lst[index++]);
    }
}
