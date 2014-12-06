using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  EquipActionbattleAddCritical.cs
//  Author: Lu Zexi
//  2014-01-21


/// <summary>
/// 战斗装备action 增加 暴击
/// </summary>
public class EquipActionBattleAddCritical : CAction
{
    private float m_fCriticalRateInc;  //暴击比率增加

    public EquipActionBattleAddCritical(int id, int actionType, int runType)
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

        hero.m_cCritical.AddValue(this.m_fCriticalRateInc);

        UnityEngine.Debug.Log("cri " + hero.m_cCritical.GetFinalData());

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

        
        hero.m_cCritical.RemoveValue(this.m_fCriticalRateInc);

        UnityEngine.Debug.Log("cri " + hero.m_cCritical.GetFinalData());

        return ACTION_ERROR_CODE.NONE;
    }


    /// <summary>
    /// 读取数据
    /// </summary>
    /// <param name="lst"></param>
    /// <param name="index"></param>
    public override void Read(List<string> lst, ref int index)
    {
        this.m_fCriticalRateInc = float.Parse(lst[index++]);
    }

}
