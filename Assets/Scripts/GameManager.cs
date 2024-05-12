using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Material goodMaterial;
    public Material badMaterial;
    public CommandController commandController;
    public PlatformController platformController;
    public int life = 5;

    private int score;

    public void OnClick(int button)
    {
        if (platformController.isStarted && platformController.clickCount >= 1)
        {
            if (button == commandController.newCommand)
            {
                score += 1;
                platformController.platform1.GetComponent<MeshRenderer>().material = goodMaterial;
                platformController.platform2.GetComponent<MeshRenderer>().material = goodMaterial;
            }

            else if (button != commandController.newCommand)
            {
                life -= 1;
                platformController.platform1.GetComponent<MeshRenderer>().material = badMaterial;
                platformController.platform2.GetComponent<MeshRenderer>().material = badMaterial;
            }
        }
    }

    private void Update()
    {
        //if (platformController.isStarted)
        //{
        //    if (life <= 0)
        //    {
        //        platformController.GameOver();
        //    }
        //}
    }
}
