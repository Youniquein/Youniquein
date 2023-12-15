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
    public Image monster;
    public Image charicter;
    public TextMeshProUGUI damage;
    public TextMeshProUGUI turn;
    public TextMeshProUGUI charHp;
    public TextMeshProUGUI monHp;

    public void Turn()
    {
        if (click %2 == 1)
        {
            if (chrHpStats < 50)
            { chrHpStats = 100; }

            else if (chrHpStats > 50)
            {
                monHpStats -= chrHit;
                monHp = monHpStats.ToString();
                damage = chrHit.ToString();
                turn = 
            }
    }

}
