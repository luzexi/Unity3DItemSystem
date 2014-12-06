using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  IAction.cs
//  Author: Lu Zexi
//  2013-12-24



//action error code
public enum ACTION_ERROR_CODE
{ 
    NONE = 0,   //no error
    ERROR = 1,  //error
}


//action error 
public class ActionError
{
	public ACTION_ERROR_CODE code = ACTION_ERROR_CODE.NONE;	//error code
	public string desc = "";	//error describe

	public ActionError()
	{
		//
	}

	public ActionError(ACTION_ERROR_CODE c)
	{
		this.code = c;
	}

	public ActionError( ACTION_ERROR_CODE c , string d )
	{
		this.code = c;
		this.desc = d;
	}

	//no error
	public static ActionError NoError
	{
		get
		{
			return new ActionError(ACTION_ERROR_CODE.NONE);
		}
	}
}


//interface
public interface IAction
{
    ActionError Excute( ActionInput input );  //excute
    ActionError RollBack( ActionInput input );  //rollback
}

