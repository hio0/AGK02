using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array_Practice : MonoBehaviour
{
    public int[] scores = new int[5];
    public int sum;
    public int highscore;

    // Start is called before the first frame update
    void Start()
    {
        scores[0] = 60;
        scores[1] = 70;
        scores[2] = 80;
        scores[3] = 90;
        scores[4] = 100;

        Debug.Log("배열 실습");

        for(int i = 0;i < scores.Length;i++)
        {
            Debug.Log($"{i+1}번재 점수: {scores[i]}");

            sum += scores[i];

            if (scores[i] > highscore)
            {
                highscore = scores[i];
            }
        }

        Debug.Log("합계: " + sum);
        Debug.Log("최고 점수: " + highscore);

        int peungun = sum / scores.Length;
        //float ad = (float)sum / scores.Length; <- 변수 자료형 변경
        Debug.Log("평균: " + peungun);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
