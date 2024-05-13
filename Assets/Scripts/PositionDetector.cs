using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionDetector : MonoBehaviour
{
    public bool playerPos;
    //public Material playerOneMaterial;
    //public Material playerTwoMaterial;

    //private Material material;

    private void OnEnable()
    {
        playerPos = false;
        //material = gameObject.GetComponent<MeshRenderer>().material;
    }

    private void OnTriggerStay(Collider other)
    {
        playerPos = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playerPos = false;
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    //if (material = playerOneMaterial)
    //    //{
    //    //    if (other.gameObject.name.Contains("Center"))
    //    //    {
    //    //        playerPos = true;
    //    //    }
    //    //}

    //    //else if (material = playerTwoMaterial)
    //    //{
    //    //    if (other.gameObject.name.Contains("Right"))
    //    //    {
    //    //        playerPos = true;
    //    //    }
    //    //}

    //    playerPos = true;
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (gameObject.name.Contains("Center"))
    //    {
    //        if (other.gameObject.name.Contains("Platform"))
    //        {
    //            if (other.gameObject.GetComponent<MeshRenderer>().material == playerOneMaterial)
    //            {
    //                playerPos = true;
    //            }
    //        }
    //    }

    //    else if (gameObject.name.Contains("Right"))
    //    {
    //        if (other.gameObject.name.Contains("Platform"))
    //        {
    //            if (other.gameObject.GetComponent<MeshRenderer>().material == playerTwoMaterial)
    //            {
    //                playerPos = true;
    //            }
    //        }
    //    }

    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (gameObject.name.Contains("Center"))
    //    {
    //        if (other.gameObject.name.Contains("Platform"))
    //        {
    //            if (other.gameObject.GetComponent<MeshRenderer>().material == playerOneMaterial)
    //            {
    //                playerPos = false;
    //            }
    //        }
    //    }

    //    else if (gameObject.name.Contains("Right"))
    //    {
    //        if (other.gameObject.name.Contains("Platform"))
    //        {
    //            if (other.gameObject.GetComponent<MeshRenderer>().material == playerTwoMaterial)
    //            {
    //                playerPos = false;
    //            }
    //        }
    //    }
    //}
}
