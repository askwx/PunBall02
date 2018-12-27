using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    //スコアを表示するテキスト
    private GameObject scoreText;
    private int score = 0; //スコア計算用変数
    public void AddScore()
    {
        this.score += 10;
    }

    // Use this for initialization
    void Start()
    {


        score = 0;
        //scoreの文字を表示させる。find→getcomponent
        this.scoreText = GameObject.Find("Score");
        this.scoreText.GetComponent<Text>().text = "score";

    }


    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        //ターゲット名を取得
        string targetTag = other.gameObject.tag;

        // タグによって点数を変える、+10,+20,0
        if (other.gameObject.tag == "SmallStarTag")

        {
            this.score = score += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.score = score += 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag" || other.gameObject.tag == "LargeCloudTag")
        {
            this.score = score = 0;

        }


        //スコアを表示？
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D3");



    }
        
    }




