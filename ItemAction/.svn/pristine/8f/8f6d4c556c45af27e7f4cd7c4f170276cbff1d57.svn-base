using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  EquipActionBattleAddOppose.cs
//  Author: Lu Zexi
//  2014-01-21


/// <summary>
/// 战斗装备 action 增加抗体
/// </summary>
public class EquipActionBattleAddOppose : CAction
{
    private float m_fDuInc; //毒概率增加
    private float m_fXuruoInc;  //虚弱概率增加
    private float m_fPojiaInc;  //破甲概率增加
    private float m_fPorenInc;  //破刃概率增加
    private float m_fMaInc; //麻痹概率增加
    private float m_fFengyinInc;    //封印概率增加

    public EquipActionBattleAddOppose(int id, int actionType, int runType)
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

        hero.m_cOpposeDu.AddValue(this.m_fDuInc);
        hero.m_cOpposeXuruo.AddValue(this.m_fXuruoInc);
        hero.m_cOpposePojia.AddValue(this.m_fPojiaInc);
        hero.m_cOpposePoren.AddValue(this.m_fPorenInc);
        hero.m_cOpposeMa.AddValue(this.m_fMaInc);
        hero.m_cOpposeFengyin.AddValue(this.m_fFengyinInc);

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

        hero.m_cOpposeDu.RemoveValue(this.m_fDuInc);
        hero.m_cOpposeXuruo.RemoveValue(this.m_fXuruoInc);
        hero.m_cOpposePojia.RemoveValue(this.m_fPojiaInc);
        hero.m_cOpposePoren.RemoveValue(this.m_fPorenInc);
        hero.m_cOpposeMa.RemoveValue(this.m_fMaInc);
        hero.m_cOpposeFengyin.RemoveValue(this.m_fFengyinInc);

        return ACTION_ERROR_CODE.NONE;
    }

    /// <summary>
    /// 读取数据
    /// </summary>
    /// <param name="lst"></param>
    /// <param name="index"></param>
    public override void Read(List<string> lst, ref int index)
    {
        this.m_fDuInc = float.Parse(lst[index++]);
        this.m_fXuruoInc = float.Parse(lst[index++]);
        this.m_fPojiaInc = float.Parse(lst[index++]);
        this.m_fPorenInc = float.Parse(lst[index++]);
        this.m_fMaInc = float.Parse(lst[index++]);
        this.m_fFengyinInc = float.Parse(lst[index++]);
    }

}
