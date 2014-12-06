using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  ActionBattleFullSkill.cs
//  Author: Lu Zexi
//  2013-12-25




/// <summary>
/// 战场满技能槽Action
/// </summary>
public class ActionBattleFullSkill : CAction
{
    public ActionBattleFullSkill(int id, int actionType, int runType)
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

        if (aInput.GetBattleHero() == null)
            return ACTION_ERROR_CODE.ERROR;

        aInput.GetBattleHero().m_fBBHP = aInput.GetBattleHero().m_iBBMaxHP;

        IGUIBattle gui = (IGUIBattle)GameManager.GetInstance().GetGUIManager().GetGUI(GameManager.GetInstance().GetGUIManager().GetCurGUIID());
        gui.SetUIHeroBBHP(aInput.GetBattleHero());

        return ACTION_ERROR_CODE.NONE;
    }

}
