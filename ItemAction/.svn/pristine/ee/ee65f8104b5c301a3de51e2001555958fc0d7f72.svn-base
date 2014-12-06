using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  EquipActionBattleAddDrop.cs
//  Author: Lu Zexi
//  2014-01-21



/// <summary>
/// 战斗装备action 增加掉落率
/// </summary>
public class EquipActionBattleAddDrop : CAction
{
    private float m_fJinbiDropInc;  //增加金币掉落率
    private float m_fShuijingDropInc;   //增加水晶掉落率
    private float m_fFarmDropInc;   //增加农场掉落率
    private float m_fHeartDropInc;  //增加心掉落率
    private float m_fItemDropInc;   //增加物品掉落率

    public EquipActionBattleAddDrop(int id, int actionType, int runType)
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

        hero.m_cJinbiDropRateInc.AddValue(this.m_fJinbiDropInc);
        hero.m_cFarmDropRateInc.AddValue(this.m_fFarmDropInc);
        hero.m_cXinDropRateInc.AddValue(this.m_fHeartDropInc);
        hero.m_cShuijingDropRateInc.AddValue(this.m_fShuijingDropInc);
        hero.m_cItemDropRateInc.AddValue(this.m_fItemDropInc);

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

        hero.m_cJinbiDropRateInc.RemoveValue(this.m_fJinbiDropInc);
        hero.m_cFarmDropRateInc.RemoveValue(this.m_fFarmDropInc);
        hero.m_cXinDropRateInc.RemoveValue(this.m_fHeartDropInc);
        hero.m_cShuijingDropRateInc.RemoveValue(this.m_fShuijingDropInc);
        hero.m_cItemDropRateInc.RemoveValue(this.m_fItemDropInc);

        return ACTION_ERROR_CODE.NONE;
    }

    /// <summary>
    /// 读取文本数据
    /// </summary>
    /// <param name="lst"></param>
    /// <param name="index"></param>
    public override void Read(List<string> lst, ref int index)
    {
        this.m_fJinbiDropInc = float.Parse(lst[index++]);
        this.m_fShuijingDropInc = float.Parse(lst[index++]);
        this.m_fFarmDropInc = float.Parse(lst[index++]);
        this.m_fHeartDropInc = float.Parse(lst[index++]);
        this.m_fItemDropInc = float.Parse(lst[index++]);
    }

}
