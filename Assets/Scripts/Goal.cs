using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    public bool Player1Goal = true;
    public TextMeshProUGUI scoreBox;

    public static int Player1Score = 0;
    public static int Player2Score = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Player1Goal)
        {
            Player2Score++;
        }
        else
        {
            Player1Score++;
        }

        scoreBox.text = $"{Player1Score} : {Player2Score}";
    }
}
