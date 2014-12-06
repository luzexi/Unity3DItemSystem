using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  EquipActionBattleIncBUFF.cs
//  Author: Lu Zexi
//  2014-02-12





/// <summary>
/// 装备Action 提升使对方获得BUFF的几率
/// </summary>
public class EquipActionBattleIncBUFF : CAction
{
    private float m_fDuInc; //毒概率增加
    private float m_fXuruoInc;  //虚弱概率增加
    private float m_fPojiaInc;  //破甲概率增加
    private float m_fPorenInc;  //破刃概率增加
    private float m_fMaInc; //麻痹概率增加
    private float m_fFengyinInc;    //封印概率增加

    public EquipActionBattleIncBUFF(int id, int actionType, int runType)
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

        hero.m_cDuRate.AddValue(this.m_fDuInc);
        hero.m_iDuRound++;
        hero.m_cXuRuoRate.AddValue(this.m_fXuruoInc);
        hero.m_iXuRuoRound++;
        hero.m_cPojiaRate.AddValue(this.m_fPojiaInc);
        hero.m_iPojiaRound++;
        hero.m_cPorenRate.AddValue(this.m_fPorenInc);
        hero.m_iPorenRound++;
        hero.m_cMaRate.AddValue(this.m_fMaInc);
        hero.m_iMaRound++;
        hero.m_cFengyinRate.AddValue(this.m_fFengyinInc);
        hero.m_iFengyinRound++;

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

        hero.m_cDuRate.RemoveValue(this.m_fDuInc);
        hero.m_iDuRound--;
        hero.m_cXuRuoRate.RemoveValue(this.m_fXuruoInc);
        hero.m_iXuRuoRound--;
        hero.m_cPojiaRate.RemoveValue(this.m_fPojiaInc);
        hero.m_iPojiaRound--;
        hero.m_cPorenRate.RemoveValue(this.m_fPorenInc);
        hero.m_iPorenRound--;
        hero.m_cMaRate.RemoveValue(this.m_fMaInc);
        hero.m_iMaRound--;
        hero.m_cFengyinRate.RemoveValue(this.m_fFengyinInc);
        hero.m_iFengyinRound--;

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
