using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public PlatformController platformController;
    public GameManager gameManager;

    void Update()
    {
        if (platformController.isStarted)
        {
            if (OVRInput.GetDown(OVRInput.RawButton.A) && platformController.isStarted)
            {
                platformController.clickCount += 1;
                gameManager.OnClick(0);
            }
            else if (OVRInput.GetDown(OVRInput.RawButton.B) && platformController.isStarted)
            {
                gameManager.OnClick(1);
            }
            else if (OVRInput.GetDown(OVRInput.RawButton.X) && platformController.isStarted)
            {
                gameManager.OnClick(2);
            }
            else if (OVRInput.GetDown(OVRInput.RawButton.Y) && platformController.isStarted)
            {
                gameManager.OnClick(3);
            }
        }
    }
}
