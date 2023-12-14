using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{
    int descNum;
    public TextMeshProUGUI descText;
    public Button startBtn;
    public GameObject textBg;

    public void ChangeDesc()
    {
        if (descNum == 0)
        {
            textBg.SetActive(true);
            startBtn.gameObject.SetActive(true);
            descText.text = "안녕.";
        }
        else if (descNum == 1)
        {
            descText.text = "내 이름은 이현승이야.";
        }
        else if (descNum == 2)
        {
            descText.text = "난 멋쟁이지.";
        }
        else if (descNum == 3)
        {
            descText.text = "집중하는 내 모습이 보이니?";
        }
        else if (descNum == 4)
        {
            descText.text = "그럼 열심히 하도록";
        }
        else
        {
            startBtn.gameObject.SetActive(false);
            textBg.SetActive(false);
        }

        if (descNum == 5)
        {
            descNum = 0;
        }
        else
        {
            descNum++;
        }
    }
 
}
