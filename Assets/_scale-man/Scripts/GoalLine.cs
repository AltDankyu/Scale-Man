using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScaleMan
{
    public class GoalLine : MonoBehaviour
    {
        [SerializeField] private GameObject winMessage;
        [SerializeField] private GameObject loseMessage;


        // private bool isplayergoal;

        // private bool iscomgoal;

        // private void Awake()
        // {
        //     isplayergoal = false;
        //     iscomgoal = false;
        // }


        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "Player")
            {
                winMessage.SetActive(true);
                Destroy(this);
            }

            // どのCOMが来てもLoseになるように修正
            else if (other.gameObject.name == "COM_Red")
            {
                loseMessage.SetActive(true);
                Destroy(this);
            }

            else if (other.gameObject.name == "COM_Green")
            {
                loseMessage.SetActive(true);
                Destroy(this);
            }

            else if (other.gameObject.name == "COM_Orange")
            {
                loseMessage.SetActive(true);
                Destroy(this);
            }



        // -----------------------------------------------------
        // ボツ
        // -----------------------------------------------------
        // private void OnTriggerEnter(Collider other)
        // {
        //     Debug.Log("iscomgoal == " + iscomgoal);

        //     Debug.Log("isplayergoal == " + isplayergoal);

        //     if (iscomgoal == false && other.gameObject.name == "Player")
        //     {
        //         Debug.Log("プレイヤーゴール");
        //         isplayergoal = true;

        //         Debug.Log("ゴール後　== isplayergoal == " + isplayergoal);
        //         winMessage.SetActive(true);
        //         Destroy(this);
        //     }

        //     // どのCOMが来てもLoseになるように修正
        //     else if (isplayergoal == false && other.gameObject.name == "COM_Red")
        //     {
        //         Debug.Log("赤ゴール");
        //         iscomgoal = true;
        //         loseMessage.SetActive(true);
        //         Destroy(this);
        //     }

        //     else if (isplayergoal == false && other.gameObject.name == "COM_Green")
        //     {
        //         Debug.Log("緑ゴール");
        //         iscomgoal = true;
        //         loseMessage.SetActive(true);
        //         Destroy(this);
        //     }

        //     else if (isplayergoal == false && other.gameObject.name == "COM_Orange")
        //     {
        //         Debug.Log("オレンジゴール");
        //         iscomgoal = true;
        //         loseMessage.SetActive(true);
        //         Destroy(this);
        //     }




        }

        // // デバック用
        // private void Update()
        // {
        //     Debug.Log("isplayer == " + isplayergoal);
        //     Debug.Log("isComGoal == " + iscomgoal);
        // }
    }
}
