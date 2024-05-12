using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public GameObject startPlatform;
    public GameObject[] platforms;
    public Material materialOne;
    public Material materialTwo;
    public float second;
    public CommandController commandController;
    public GameManager gameManager;
    public GameObject platform1;
    public GameObject platform2;
    public bool isStarted;
    public int clickCount;
    //public GameObject soundMachine;

    private float timer;
    private GameObject previous1;
    private GameObject previous2;
    //private AudioSource music;

    private void Start()
    {
        second = 3f;
        isStarted = false;
        timer = 0f;
        clickCount = 0;
        //music = soundMachine.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One) && !isStarted)
        {
            //music.Play();
            startPlatform.SetActive(false);
            isStarted = true;
            StartCoroutine(SpawnPlatform());
        }

        if (isStarted)
        {
            timer += Time.deltaTime;
        }
    }

    public void GameOver()
    {
        StopCoroutine(SpawnPlatform());
    }

    IEnumerator SpawnPlatform()
    {
        while (true)
        {
            if (timer >= 30f)
            {
                second = second/1.33f;
                timer = 0f;
            }

            platform1 = platforms[Random.Range(0, platforms.Length)];
            platform2 = platforms[Random.Range(0, platforms.Length)];

            while (platform1 == previous1)
            {
                platform1 = platforms[Random.Range(0, platforms.Length)];
            }

            while (platform2 == previous2)
            {
                platform2 = platforms[Random.Range(0, platforms.Length)];
            }

            while (platform2 == platform1)
            {
                platform2 = platforms[Random.Range(0, platforms.Length)];
            }

            platform1.GetComponent<MeshRenderer>().material = materialOne;
            platform2.GetComponent<MeshRenderer>().material = materialTwo;
            platform1.SetActive(true);
            platform2.SetActive(true);

            yield return new WaitForSeconds(second);

            previous1 = platform1;
            previous2 = platform2;

            //if (previous1.GetComponent<MeshRenderer>().material != gameManager.goodMaterial)
            //{
            //    gameManager.life -= 1;
            //}

            platform1.SetActive(false);
            platform2.SetActive(false);
            commandController.ChangeCommand();
        }
    }
}
