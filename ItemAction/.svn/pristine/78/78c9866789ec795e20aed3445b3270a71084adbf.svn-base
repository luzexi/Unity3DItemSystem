using System;
using System.Collections.Generic;
using UnityEngine;


//  ActionBattleRelive.cs
//  Author: Lu Zexi
//  2013-12-25



/// <summary>
/// 战场复活Action
/// </summary>
public class ActionBattleRelive : CAction
{
    public ActionBattleRelive(int id, int actionType, int runType)
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

        aInput.GetBattleHero().m_bDead = false;
        aInput.GetBattleHero().AddHP(1);
        aInput.GetBattleHero().GetGfxObject().SetLocalScale(Vector3.one);

        IGUIBattle gui = (IGUIBattle)GameManager.GetInstance().GetGUIManager().GetGUI(GameManager.GetInstance().GetGUIManager().GetCurGUIID());
        gui.SetUIHeroAttackNum(aInput.GetBattleHero());
        gui.SetUIHeroHP(aInput.GetBattleHero());

        return ACTION_ERROR_CODE.NONE;
    }

}
