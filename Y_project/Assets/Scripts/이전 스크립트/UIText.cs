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
            descText.text = "�ȳ�.";
        }
        else if (descNum == 1)
        {
            descText.text = "�� �̸��� �������̾�.";
        }
        else if (descNum == 2)
        {
            descText.text = "�� ��������.";
        }
        else if (descNum == 3)
        {
            descText.text = "�����ϴ� �� ����� ���̴�?";
        }
        else if (descNum == 4)
        {
            descText.text = "�׷� ������ �ϵ���";
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
