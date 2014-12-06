using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//  CAction.cs
//  Author: Lu Zexi
//  2013-12-24



//base action
public abstract class CAction : IAction
{
    private int m_iID;  //id

    // id (0-99999) , actionType(0-99) , runType(0-99)
    public CAction(int id, int actionType, int runType)
    {
        this.m_iID = actionType*10000000 + runType*100000 + id;
    }

    public abstract ActionError Excute(ActionInput input);

    //roll back action
    public virtual ActionError RollBack(ActionInput input)
    {
        return ActionError.NoError;
    }

    //get id
    public int GetID()
    {
        return this.m_iID;
    }
}
