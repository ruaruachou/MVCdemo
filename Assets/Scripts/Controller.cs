using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public View view;
    public Button AddLevel;
    public Button AddExp;
    public Button AddMoney;

    void Start()
    {
        Model.Instsance.AddUpdateEvent(view.UpdateView); 

        AddLevel.onClick.AddListener(Model.Instsance.Addlevel);
        AddExp.onClick.AddListener(Model.Instsance.AddExp);
        AddMoney.onClick.AddListener(Model.Instsance.AddGold);
    }
}
