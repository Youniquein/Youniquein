using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BoxRandom : MonoBehaviour
{
    public Button boxone;
    public Button box;
    public TextMeshProUGUI goldNum;
    public TextMeshProUGUI emeNum;
    public TextMeshProUGUI lubNum;
    public TextMeshProUGUI get;

    int goldNumb = 0;
    int emeNumb = 0;
    int lubNumb = 0;

    int open = 1;

    public void BoxOpen()
    {
        open++;

        if (open >= 0)
        {
            for (open = 0; open <= 100; open++) {

                int randValue;
                randValue = Random.Range(0, 3);     // ���, ���, ���޶��� ���� �� ����

                if (randValue == 0)     // ���� �� 0 ��� �� ���
                {
                    int randValueGold;
                    randValueGold = Random.Range(1, 101);

                    get.text = "��� " + randValueGold.ToString() + "�� ȹ��!";

                    goldNumb += randValueGold;
                    goldNum.text = "��� " + goldNumb.ToString();
                }

                if (randValue == 1)     // ���� �� 1 ��� �� ���޶���
                {
                    int randValueEme;
                    randValueEme = Random.Range(1, 101);

                    get.text = "���޶��� " + randValueEme.ToString() + "�� ȹ��!";

                    emeNumb += randValueEme;
                    emeNum.text = "���޶��� " + emeNumb.ToString();
                }

                if (randValue == 2)     // ���� �� 2 ��� �� ���
                {
                    int randValueLub;
                    randValueLub = Random.Range(1, 101);

                    get.text = "��� " + randValueLub.ToString() + "�� ȹ��!";

                    lubNumb += randValueLub;
                    lubNum.text = "��� " + lubNumb.ToString();
                }
            }

            int goldResult = goldNumb;
            int emeResult = emeNumb;
            int lubResult = lubNumb;     // 100�� �����Ͽ��� �� �հ�

            get.text = "���" + goldResult.ToString() + "��\n" + "���" + lubResult.ToString() + "��\n" + "���޶���" + emeResult.ToString() + "�� ȹ��!";
        }

    }

    public void BoxOpenone()
    {
        open++;

        if (open >= 0)
        {
            int randValue;
            randValue = Random.Range(0, 3);

            if (randValue == 0)
            {
                int randValueGold;
                randValueGold = Random.Range(1, 101);

                get.text = "��� " + randValueGold.ToString() + "�� ȹ��!";

                goldNumb += randValueGold;
                goldNum.text = "��� " + goldNumb.ToString();
            }

            if (randValue == 1)
            {
                int randValueEme;
                randValueEme = Random.Range(1, 101);

                get.text = "���޶��� " + randValueEme.ToString() + "�� ȹ��!";

                emeNumb += randValueEme;
                emeNum.text = "���޶��� " + emeNumb.ToString();
            }

            if (randValue == 2)
            {
                int randValueLub;
                randValueLub = Random.Range(1, 101);

                get.text = "��� " + randValueLub.ToString() + "�� ȹ��!";

                lubNumb += randValueLub;
                lubNum.text = "��� " + lubNumb.ToString();
            }

        }
    }
}
