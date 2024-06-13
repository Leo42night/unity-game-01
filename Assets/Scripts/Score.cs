using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TMP_Text scoreText;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + player.position.z.ToString("0"); 
    } 
}
