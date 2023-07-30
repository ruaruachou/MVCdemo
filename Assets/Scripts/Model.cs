using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model
{
    private string name;
    private int level;
    private int exp;
    private int gold;

    public string Name { get { return name; } }
    public int Level { get { return level; } }
    public int Exp { get { return exp; } }
    public int Gold { get { return gold; } }

    public void Addlevel()
    {
        level++;
        Debug.Log("Add level");
        Debug.Log("Level:" + level);
        CallUpdateEvent();
    }
    public void AddExp()
    {
        exp += 10;
        if (exp >= 100)
        {
            exp -= 100;
            level++;
        }
        CallUpdateEvent();
    }
    public void AddGold()
    {
        gold += 10;
        CallUpdateEvent() ;
    }
    private event Action<Model> UpdateEvent;//UpdateEvent可以被看作方法来直接调用
    public void AddUpdateEvent(Action<Model> action)
    {
        UpdateEvent += action;
        CallUpdateEvent();
    }
    public void CallUpdateEvent()
    {
        UpdateEvent?.Invoke(this);//这句等价于 if (UpdateEvent != null)    {UpdateEvent(this);}
        {
            UpdateEvent(this);
        }
    }
    private static Model model;
    public static Model Instsance
    {
        get
        {
            if (model == null)
            {
                model = new Model();
            }
            return model;
        }
    }
}

