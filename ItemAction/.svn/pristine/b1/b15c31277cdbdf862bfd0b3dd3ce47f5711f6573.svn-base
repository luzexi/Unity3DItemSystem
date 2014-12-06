using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  IAction.cs
//  Author: Lu Zexi
//  2013-12-24


/// <summary>
/// Action错误码
/// </summary>
public enum ACTION_ERROR_CODE
{ 
    NONE = 0,   //无错误
    ERROR = 1,  //错误
    ERROR_TIME_SCENE,   //时间场景错误
    ERROR_EXU_NUM,  //执行次数错误
    MAX,
}


/// <summary>
/// Action接口
/// </summary>
public interface IAction
{
    ACTION_ERROR_CODE Excute( ActionInput input );  //执行
    ACTION_ERROR_CODE RollBack( ActionInput input );  //回滚
}
