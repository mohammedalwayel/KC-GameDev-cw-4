using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanegar : MonoBehaviour
{

    int score = 1;
    int incroment = 1;

    public Text text1;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void increce()
    {
        score += incroment;

        text1.text = score.ToString();


    }

    public void store()
    {
        if (score > 5)
        {

            incroment++;
            score -= 5;
            text1.text = score.ToString();

        }

        else
        {

            print("you dont have enuph score "); 
        }

    }
}
