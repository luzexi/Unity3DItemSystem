using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  EquipReqActionBattleShuijing.cs
//  Author: Lu Zexi
//  2014-01-21




/// <summary>
/// 战斗装备需求水晶
/// </summary>
public class EquipReqActionBattleShuijing : CAction
{
    private float m_fShuijingMinRate;   //水晶最小比率
    private float m_fShuijingMaxRate;   //水晶最大比率

    public EquipReqActionBattleShuijing(int id, int actionType, int runType)
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

        float shuijingRate = 0;
        if(hero.m_iBBMaxHP > 0 )
            shuijingRate = hero.m_fBBHP / hero.m_iBBMaxHP;

        if (shuijingRate >= this.m_fShuijingMinRate && shuijingRate <= this.m_fShuijingMaxRate)
        {
            return ACTION_ERROR_CODE.NONE;
        }

        return ACTION_ERROR_CODE.ERROR;
    }

    /// <summary>
    /// 读取文本
    /// </summary>
    /// <param name="lst"></param>
    /// <param name="index"></param>
    public override void Read(List<string> lst, ref int index)
    {
        this.m_fShuijingMinRate = float.Parse(lst[index++]);
        this.m_fShuijingMaxRate = float.Parse(lst[index++]);
    }

}
