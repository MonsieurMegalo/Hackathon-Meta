using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandController : MonoBehaviour
{
    public GameObject[] commands;
    public GameObject currentCommand;
    public int newCommand;

    private bool isChanging;

    public void ChangeCommand()
    {
        newCommand = Random.Range(0, commands.Length);
        isChanging = true;
    }

    private void Update()
    {
        if (isChanging)
        {
            currentCommand.SetActive(false);
            commands[newCommand].SetActive(true);
            currentCommand = commands[newCommand];
        }
    }
}
