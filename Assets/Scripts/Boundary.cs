using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    public GameObject[] walls;
    public Material redMaterial;

    private Material baseMaterial;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("controller"))
        {
            foreach (var wall in walls)
            {
                var currentMaterial = wall.GetComponent<MeshRenderer>().material;
                baseMaterial = currentMaterial;
                currentMaterial = redMaterial;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Contains("controller"))
        {
            foreach (var wall in walls)
            {

                wall.GetComponent<MeshRenderer>().material = baseMaterial;
            }
        }
    }
}
