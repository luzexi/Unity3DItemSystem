using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  EquipActionBattleAddHP.cs
//  Author: Lu Zexi
//  2014-01-21



/// <summary>
/// 战斗装备action 增加HP
/// </summary>
public class EquipActionBattleAddHP : CAction
{
    private int m_iHP;  //增加HP
    private float m_fHPRate;    //回复系数

    public EquipActionBattleAddHP(int id, int actionType, int runType)
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

        hero.AddHP((int)(this.m_iHP+ (hero.m_cRecover.GetFinalData()* this.m_fHPRate)));

        IGUIBattle gui = (IGUIBattle)GameManager.GetInstance().GetGUIManager().GetGUI(GameManager.GetInstance().GetGUIManager().GetCurGUIID());
        gui.SetUIHeroHP(hero);

        return ACTION_ERROR_CODE.NONE;
    }

    /// <summary>
    /// 读取
    /// </summary>
    /// <param name="lst"></param>
    /// <param name="index"></param>
    public override void Read(List<string> lst, ref int index)
    {
        this.m_iHP = int.Parse(lst[index++]);
        this.m_fHPRate = float.Parse(lst[index++]);
    }
}
