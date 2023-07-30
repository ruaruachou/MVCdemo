using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Level;
    public TextMeshProUGUI Exp;
    public TextMeshProUGUI Gold;

    public void UpdateView(Model model)
    {
        Name.text = "Name:" + model.Name;
        Level.text = "Level:" + model.Level;
        Exp.text = "Exp:" + model.Exp;
        Gold.text = "Gold:" + model.Gold;
    }

}
