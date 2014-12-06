using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  ActionBattleAddHP.cs
//  Author: Lu Zexi
//  2013-12-25


/// <summary>
/// 战场增加HPAction
/// </summary>
public class ActionBattleAddHP : CAction
{
    private int m_iHP;  //增加HP
    private float m_fHPRate;    //HP回复系数

    public ActionBattleAddHP(int id, int actionType, int runType)
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

        int addHp = this.m_iHP + (int)(this.m_fHPRate * aInput.GetBattleHero().m_cRecover.GetFinalData());
        aInput.GetBattleHero().AddHP(addHp);

        IGUIBattle gui = (IGUIBattle)GameManager.GetInstance().GetGUIManager().GetGUI(GameManager.GetInstance().GetGUIManager().GetCurGUIID());
        gui.SetUIHeroHP(aInput.GetBattleHero());
        gui.GeneratorRecoverNum(aInput.GetBattleHero().m_cUIStartPos, addHp , aInput.GetBattleHero());
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
        this.m_fHPRate = float.Parse(lst[index++]);
    }
}
