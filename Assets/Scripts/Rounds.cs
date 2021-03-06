using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rounds : MonoBehaviour
{
    private static float round = 1;
    private bool isPlaying;

    public PlayerController player_1;
    public PlayerTwoController player_2;
    public Text roundtext;



    private void Start()
    {
        isPlaying = true;
        roundtext.text = "Round: " + round;
    }

    void Update()
    {
        if (isPlaying && (player_1.PlayerHealth < 1 || player_2.PlayerTwoHealth < 1))
        {
            isPlaying = false;
            round++;
            StartCoroutine(NextRound(3f));
        }
    }

    IEnumerator NextRound (float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("SampleScene");
    }

}
