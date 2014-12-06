using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  ActionBattleCleanBUFF.cs
//  Author: Lu Zexi
//  2013-12-25



/// <summary>
/// 战场清除BUFF Action
/// </summary>
public class ActionBattleCleanBUFF : CAction
{
    private BATTLE_BUF m_eBUFF; //BUFF

    public ActionBattleCleanBUFF(int id, int actionType, int runType)
        :base(id , actionType , runType)
    { 
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

        aInput.GetBattleHero().BUFClean(this.m_eBUFF);

        if (this.m_eBUFF == BATTLE_BUF.MA)
        {
            IGUIBattle gui = (IGUIBattle)GameManager.GetInstance().GetGUIManager().GetGUI(GameManager.GetInstance().GetGUIManager().GetCurGUIID());
            gui.SetUIHeroAttackNum(aInput.GetBattleHero());
        }

        return ACTION_ERROR_CODE.NONE;
    }

    /// <summary>
    /// 读取数据
    /// </summary>
    /// <param name="lst"></param>
    /// <param name="index"></param>
    public override void Read(List<string> lst, ref int index)
    {
        this.m_eBUFF = (BATTLE_BUF)int.Parse(lst[index++]);
    }
}
