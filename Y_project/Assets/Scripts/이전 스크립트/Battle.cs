using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Battle : MonoBehaviour
{
    int click = 1;

    int monHpStats = 100;
    int monHit = 10;
    int chrHpStats = 100;
    int chrHit = 15;

    public Button hit;
    public TextMeshProUGUI damage;
    public TextMeshProUGUI turn;
    public TextMeshProUGUI charHp;
    public TextMeshProUGUI monHp;

    public void Turn()
    {   click++;    // 턴 수 카운트

        if (click % 2 == 0)     // 턴 수가 짝수일 때
        {
            if (chrHpStats < 50)    // 캐릭터 HP 50 미만 시 실행
            {
                turn.text = "내 턴!";
                chrHpStats = 100;
                charHp.text = "100";
                charHp.text = chrHpStats.ToString();
            }

            else if (chrHpStats >= 50)    // 캐릭터 HP 50 이상 시 실행
            {
                turn.text = "내 턴!";
                monHpStats -= chrHit;
                damage.text = chrHit.ToString();
                monHp.text = monHpStats.ToString();
                charHp.text = chrHpStats.ToString();
            }

        }

        else if (click % 2 == 1)     // 턴 수가 홀수일 때
        {
            if (monHpStats <= 0)    // 몬스터 HP 0 이하 시 실행
            {
                turn.text = "몬스터 턴";
                monHp.text = "0";
                monHpStats = 100;
                monHp.text = "100";
                monHp.text = monHpStats.ToString();
            }

            if (monHpStats > 0)    // 몬스터 HP 0 초과 시 실행
            {
                turn.text = "몬스터 턴";
                chrHpStats -= monHit;
                damage.text = monHit.ToString();
                charHp.text = chrHpStats.ToString();
            }
        }

    }

}
