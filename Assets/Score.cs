using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TMP_Text scoreText;
    // Update is called once per frame
    void Update()
    {
        int playerMeasure = (int)(player.position.z+0.5f);
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = "Score: " + playerMeasure.ToString(); 
    } 
}
