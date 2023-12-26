using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Gacha : MonoBehaviour
{
    public Button box;
    public TextMeshProUGUI s1;
    public TextMeshProUGUI s2;
    public TextMeshProUGUI s3;
    public TextMeshProUGUI s4;
    public TextMeshProUGUI s5;
    public TextMeshProUGUI get;

    int ss1 = 0;
    int ss2 = 0;
    int ss3 = 0;
    int ss4 = 0;
    int ss5 = 0;

    int open = 1;

    public void gachacha()
    {
        open++;

        if (open >= 0)
            for (open = 0; open <= 30; open++)   // 30¿¬Â÷±îÁö ÁøÇà
            {

                int randValue;
                randValue = Random.Range(0, 101);    // È®·ü »êÁ¤

                if (randValue <= 20)     // 1¼º È¹µæ
                {
                    int ss1random;
                    ss1random = Random.Range(20, 30);

                    ss1 += ss1random;

                }
                if (randValue > 20 && randValue <= 50)     // 2¼º È¹µæ
                {
                    int ss2random;
                    ss2random = Random.Range(15, 25);

                    ss2 += ss2random;
                }

                if (randValue > 50 && randValue <= 90)     // 3¼º È¹µæ
                {
                    int ss3random;
                    ss3random = Random.Range(10, 20);

                    ss3 += ss3random;
                }

                if (randValue > 90 && randValue <= 98)     // 4¼º È¹µæ
                {
                    int ss4random;
                    ss4random = Random.Range(5, 10);

                    ss4 += ss4random;
                }

                if (randValue > 98 && randValue <= 100)     // 5¼º È¹µæ
                {
                    int ss5random;
                    ss5random = Random.Range(1, 5);

                    ss5 += ss5random;
                }
                }
        
        switch (ss5)     // 30¿¬Â÷ ÁøÇà ÈÄ 5¼º È¹µæµÇÁö ¾Ê¾ÒÀ» ½Ã
        {
            case 0:
                ss5 ++;
                break;
        }

        int ss1R = ss1;
                int ss2R = ss2;
                int ss3R = ss3;
                int ss4R = ss4;
                int ss5R = ss5;

                get.text = "1¼º" + ss1R.ToString() + "°³\n" + "2¼º" + ss2R.ToString() + "°³\n" + "3¼º" + ss3R.ToString() + "°³\n" + "4¼º" + ss4R.ToString() + "°³\n" + "5¼º" + ss5R.ToString() + "°³ È¹µæ!";
            }
    }
