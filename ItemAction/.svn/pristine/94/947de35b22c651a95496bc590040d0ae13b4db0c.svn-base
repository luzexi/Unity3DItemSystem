using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  ActionBattleAddAllHP
//  Author: Lu Zexi
//  2013-12-26


/// <summary>
/// 战场增加全体HP
/// </summary>
public class ActionBattleAddAllHP : CAction
{
    private int m_iHP;  //增加的HP
    private float m_fHpRate;    //增加系数

    public ActionBattleAddAllHP(int id, int actionType, int runType)
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

        for (int i = 0; i < aInput.GetBattleAllHero().Length; i++)
        {
            if (aInput.GetBattleAllHero()[i] == null || aInput.GetBattleAllHero()[i].m_bDead )
                continue;

            int addHp = this.m_iHP + (int)(this.m_fHpRate * aInput.GetBattleAllHero()[i].m_cRecover.GetFinalData());
            aInput.GetBattleAllHero()[i].AddHP(addHp);

            IGUIBattle gui = (IGUIBattle)GameManager.GetInstance().GetGUIManager().GetGUI(GameManager.GetInstance().GetGUIManager().GetCurGUIID());
            gui.SetUIHeroHP(aInput.GetBattleAllHero()[i]);
            gui.GeneratorRecoverNum(aInput.GetBattleAllHero()[i].m_cUIStartPos, addHp , aInput.GetBattleAllHero()[i]);
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
        this.m_iHP = int.Parse(lst[index++]);
        this.m_fHpRate = float.Parse(lst[index++]);
    }
}
