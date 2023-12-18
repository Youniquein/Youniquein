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
                randValue = Random.Range(0, 3);     // °ñµå, ·çºñ, ¿¡¸Þ¶öµå ·£´ý °ª ÁöÁ¤

                if (randValue == 0)     // ·£´ý °ª 0 Ãâ·Â ½Ã °ñµå
                {
                    int randValueGold;
                    randValueGold = Random.Range(1, 101);

                    get.text = "°ñµå " + randValueGold.ToString() + "¸¦ È¹µæ!";

                    goldNumb += randValueGold;
                    goldNum.text = "°ñµå " + goldNumb.ToString();
                }

                if (randValue == 1)     // ·£´ý °ª 1 Ãâ·Â ½Ã ¿¡¸Þ¶öµå
                {
                    int randValueEme;
                    randValueEme = Random.Range(1, 101);

                    get.text = "¿¡¸Þ¶öµå " + randValueEme.ToString() + "¸¦ È¹µæ!";

                    emeNumb += randValueEme;
                    emeNum.text = "¿¡¸Þ¶öµå " + emeNumb.ToString();
                }

                if (randValue == 2)     // ·£´ý °ª 2 Ãâ·Â ½Ã ·çºñ
                {
                    int randValueLub;
                    randValueLub = Random.Range(1, 101);

                    get.text = "·çºñ " + randValueLub.ToString() + "¸¦ È¹µæ!";

                    lubNumb += randValueLub;
                    lubNum.text = "·çºñ " + lubNumb.ToString();
                }
            }

            int goldResult = goldNumb;
            int emeResult = emeNumb;
            int lubResult = lubNumb;     // 100°³ ¿ÀÇÂÇÏ¿´À» ¶§ ÇÕ°è

            get.text = "°ñµå" + goldResult.ToString() + "°³\n" + "·çºñ" + lubResult.ToString() + "°³\n" + "¿¡¸Þ¶öµå" + emeResult.ToString() + "°³ È¹µæ!";
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

                get.text = "°ñµå " + randValueGold.ToString() + "¸¦ È¹µæ!";

                goldNumb += randValueGold;
                goldNum.text = "°ñµå " + goldNumb.ToString();
            }

            if (randValue == 1)
            {
                int randValueEme;
                randValueEme = Random.Range(1, 101);

                get.text = "¿¡¸Þ¶öµå " + randValueEme.ToString() + "¸¦ È¹µæ!";

                emeNumb += randValueEme;
                emeNum.text = "¿¡¸Þ¶öµå " + emeNumb.ToString();
            }

            if (randValue == 2)
            {
                int randValueLub;
                randValueLub = Random.Range(1, 101);

                get.text = "·çºñ " + randValueLub.ToString() + "¸¦ È¹µæ!";

                lubNumb += randValueLub;
                lubNum.text = "·çºñ " + lubNumb.ToString();
            }

        }
    }
}
