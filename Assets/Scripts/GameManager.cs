using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Material goodMaterial;
    public Material badMaterial;
    //public CommandController commandController;
    public PlatformController platformController;
    //public int life = 5;
    public float second;

    //private int score;
    private float timer;
    //private bool player1;
    private bool player2;

    private void Start()
    {
        timer = 0f;

    }

    public void OnClick()
    {
        if (platformController.isStarted)
        {
            //player1 = platformController.platform1.GetComponent<PositionDetector>().playerPos;
            player2 = platformController.platform2.GetComponent<PositionDetector>().playerPos;

            if (player2)
            {
                //score += 1;
                platformController.platform1.GetComponent<MeshRenderer>().material = goodMaterial;
                platformController.platform2.GetComponent<MeshRenderer>().material = goodMaterial;
                StartCoroutine(TriggerHapticsRoutine(true));
            }

            else if (!player2)
            {
                //life -= 1;
                platformController.platform1.GetComponent<MeshRenderer>().material = badMaterial;
                platformController.platform2.GetComponent<MeshRenderer>().material = badMaterial;
                StartCoroutine(TriggerHapticsRoutine(false));
            }

            //if (button == commandController.newCommand)
            //{
            //    //score += 1;
            //    platformController.platform1.GetComponent<MeshRenderer>().material = goodMaterial;
            //    platformController.platform2.GetComponent<MeshRenderer>().material = goodMaterial;
            //}

            //else if (button != commandController.newCommand)
            //{
            //    //life -= 1;
            //    platformController.platform1.GetComponent<MeshRenderer>().material = badMaterial;
            //    platformController.platform2.GetComponent<MeshRenderer>().material = badMaterial;
            //}
        }
    }

    public IEnumerator TriggerHapticsRoutine(bool state)
    {
        if (state)
        {
            OVRInput.SetControllerVibration(1f, 1f, OVRInput.Controller.RTouch);
            yield return new WaitForSeconds(0.3f);
        }

        if (!state)
        {
            OVRInput.SetControllerVibration(1f, 1f, OVRInput.Controller.RTouch);
            yield return new WaitForSeconds(1.2f);
        }

        OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.RTouch);
    }

    private void FixedUpdate()
    {
        if (platformController.isStarted)
        {
            timer += Time.deltaTime;

            if (timer >= 30f)
            {
                second = second / 1.33f;
                timer = 0f;
            }
        }

        //if (platformController.isStarted)
        //{
        //    if (life <= 0)
        //    {
        //        platformController.GameOver();
        //    }
        //}
    }
}
