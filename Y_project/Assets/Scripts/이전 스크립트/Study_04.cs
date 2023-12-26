using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public string DamageResult(long money)
    {
        string returnValue = null;
        float _money;

        if(money > 1000000)
        {
            _money = (float)(money / 1000000);
            returnValue = _money + "M";
        }

        return returnValue;
    }

}
