using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  ActionFactory.cs
//  Author: Lu Zexi
//  2013-12-24




/// <summary>
/// Action工厂
/// </summary>
public class ActionFactory
{

    /// <summary>
    /// 创建
    /// </summary>
    /// <returns></returns>
    public static CAction Create( int id , int actionType , int runType )
    {
        if (actionType == ACTION_DEFINE.EXCUTE_TYPE)
        {
            switch (runType)
            { 
                case ACTION_DEFINE.ACTION_BATTLE_ADD_HP:
                    return new ActionBattleAddHP(id, actionType, runType);
                case ACTION_DEFINE.ACTION_BATTLE_RELIVE:
                    return new ActionBattleRelive(id, actionType, runType);
                case ACTION_DEFINE.ACTION_BATTLE_ADD_BUFF:
                    return new ActionBattleAddBUFF(id, actionType, runType);
                case ACTION_DEFINE.ACTION_BATTLE_FULL_SKILL:
                    return new ActionBattleFullSkill(id, actionType, runType);
                case ACTION_DEFINE.ACTION_BATTLE_CLEAN_BUFF:
                    return new ActionBattleCleanBUFF(id, actionType, runType);
                case ACTION_DEFINE.ACTION_BATTLE_ADD_ALL_HP:
                    return new ActionBattleAddAllHP(id, actionType, runType);
                case ACTION_DEFINE.ACTION_BATTLE_ADD_ALL_BUFF:
                    return new ActionBattleAddAllBUFF(id, actionType, runType);
            }
        }
        else if (actionType == ACTION_DEFINE.REQUIRE_TYPE)
        { 
            switch (runType)
            {
                case ACTION_DEFINE.REQ_ACTION_BATTLE_DEAD:
                    return new ReqActionBattleDead(id, actionType, runType);
                case ACTION_DEFINE.REQ_ACTION_BATTLE_BUFF:
                    return new ReqActionBattleBuff(id, actionType, runType);
                case ACTION_DEFINE.REQ_ACTION_BATTLE_NATURE:
                    return new ReqActionBattleNature(id, actionType, runType);
                case ACTION_DEFINE.REQ_ACTION_BATTLE_BB_FULL:
                    return new ReqActionBattleBBFull(id, actionType, runType);
                case ACTION_DEFINE.REQ_ACTION_BATTLE_HP_FULL:
                    return new ReqActionBattleHPFull(id, actionType, runType);
                case ACTION_DEFINE.REQ_ACTION_BATTLE_BUFFS:
                    return new ReqActionBattleBuffs(id, actionType, runType);
                case ACTION_DEFINE.REQ_ACTION_BATTLE_NOT_BUFF:
                    return new ReqActionBattleNotBuff(id, actionType, runType);
            }
        }
        else if (actionType == ACTION_DEFINE.EQUIP_EXCUTE_TYPE)
        {
            switch (runType)
            {
                case ACTION_DEFINE.EQUIP_ACTION_BATTLE_ADD_BASE:
                    return new EquipActionBattleAddBase(id, actionType, runType);
                case ACTION_DEFINE.EQUIP_ACTION_BATTLE_ADD_BBHP:
                    return new EquipActionBattleAddBBHP(id, actionType, runType);
                case ACTION_DEFINE.EQUIP_ACTION_BATTLE_ADD_CRITICAL:
                    return new EquipActionBattleAddCritical(id, actionType, runType);
                case ACTION_DEFINE.EQUIP_ACTION_BATTLE_ADD_DROP:
                    return new EquipActionBattleAddDrop(id, actionType, runType);
                case ACTION_DEFINE.EQUIP_ACTION_BATTLE_ADD_HP:
                    return new EquipActionBattleAddHP(id, actionType, runType);
                case ACTION_DEFINE.EQUIP_ACTION_BATTLE_ADD_OPPOSE:
                    return new EquipActionBattleAddOppose(id, actionType, runType);
                case ACTION_DEFINE.EQUIP_ACTION_BATTLE_BUFF:
                    return new EquipActionBattleBuff(id, actionType, runType);
                case ACTION_DEFINE.EQUIP_ACTION_BATTLE_INC_BUFF:
                    return new EquipActionBattleIncBUFF(id , actionType , runType);
                case ACTION_DEFINE.EQUIP_ACTION_BATTLE_INC_EX_RATE:
                    return new EquipActionBattleIncExRate(id , actionType , runType);
            }
        }
        else if (actionType == ACTION_DEFINE.EQUIP_REQUIRE_TYPE)
        {
            switch (runType)
            {
                case ACTION_DEFINE.EQUIP_REQ_ACTION_BATTLE_TIME_SCENE:
                    return new EquipReqActionBattleTimeScene(id, actionType, runType);
                case ACTION_DEFINE.EQUIP_REQ_ACTION_BATTLE_HP:
                    return new EquipReqActionBattleHP(id, actionType, runType);
                case ACTION_DEFINE.EQUIP_REQ_ACTION_BATTLE_SHUIJING:
                    return new EquipReqActionBattleShuijing(id, actionType, runType);
                case ACTION_DEFINE.EQUIP_REQ_ACTION_BATTLE_EXCUTE_NUM:
                    return new EquipReqActionBattleExcuteNum(id, actionType, runType);
            }
        }

        return null;
    }

}
