using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day3 : MonoBehaviour
{
    public Text Scoretext;
    public int score = 0;

    int inc = 1;
    public Text Inctext;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Increase()
    {
        score += inc;
        Scoretext.text = score.ToString();
    }
    public void shop()
    {
     if (score >= 5)
        {
            score -= 5;
            inc += 1;
            Inctext.text = "increase =" + inc;
            Scoretext.text = score.ToString();
        }
    }
}
