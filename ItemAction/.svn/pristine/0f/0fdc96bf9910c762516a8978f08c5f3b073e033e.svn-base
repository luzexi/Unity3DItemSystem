using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  EquipReqActionBattleTimeScene.cs
//  Author: Lu Zexi
//  2014-01-21




/// <summary>
/// 战斗装备需求action时间场景
/// </summary>
public class EquipReqActionBattleTimeScene : CAction
{
    private BATTLE_TIME_SCENE m_eSceneTime;

    public EquipReqActionBattleTimeScene( int id , int actiontype , int runtype )
        :base(id , actiontype , runtype)
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

        if ( (BATTLE_TIME_SCENE)aInput.GetTimeScene() == this.m_eSceneTime)
            return ACTION_ERROR_CODE.NONE;
        return ACTION_ERROR_CODE.ERROR_TIME_SCENE;
    }

    /// <summary>
    /// 读取文本数据
    /// </summary>
    /// <param name="lst"></param>
    /// <param name="index"></param>
    public override void Read(List<string> lst, ref int index)
    {
        this.m_eSceneTime = (BATTLE_TIME_SCENE)int.Parse(lst[index++]);
    }

}
