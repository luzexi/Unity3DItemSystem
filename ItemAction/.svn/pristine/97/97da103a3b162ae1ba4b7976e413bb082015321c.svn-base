using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  EquipActionBattleAddBBHP.cs
//  Author: Lu Zexi
//  2014-01-21



/// <summary>
/// 战斗装备action 增加BBHP
/// </summary>
public class EquipActionBattleAddBBHP : CAction
{
    private int m_iBBHP;    //增加的BBHP

    public EquipActionBattleAddBBHP(int id, int actionType, int runType)
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

        hero.AddBBHP(this.m_iBBHP);

        IGUIBattle gui = (IGUIBattle)GameManager.GetInstance().GetGUIManager().GetGUI(GameManager.GetInstance().GetGUIManager().GetCurGUIID());
        gui.SetUIHeroBBHP(hero);

        return ACTION_ERROR_CODE.NONE;
    }


    /// <summary>
    /// 读取数据
    /// </summary>
    /// <param name="lst"></param>
    /// <param name="index"></param>
    public override void Read(List<string> lst, ref int index)
    {
        this.m_iBBHP = int.Parse(lst[index++]);
    }
}
