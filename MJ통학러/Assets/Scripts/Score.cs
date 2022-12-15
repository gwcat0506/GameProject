using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [HideInInspector]
    public int score;

    //private TextMeshProUGUI _scoreText;
    public static TextMeshProUGUI _scoreText;
    public static Score Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        Player.PlayerMovement.OnForward += UpdateScore1;
        Player.PlayerMovement.OnBackward += UpdateScore2;
        //Player.PlayerJump.JumpForward += UpdateScore3;
        CuboidPickUp.CuboidPickedUp += UpdateScore;
        CuboidPickUp2.CuboidPickedUp2 += UpdateScore3;
        _scoreText = gameObject.GetComponent<TextMeshProUGUI>();
        score = 0;

    }


    private void UpdateScore1()
    {
        score++;
        _scoreText.text = score.ToString();
    }
    private void UpdateScore2()
    {
        score--;
        _scoreText.text = score.ToString();
    }
    private void UpdateScore()
    {
        _scoreText.text = score.ToString();
    }
    private void UpdateScore3()
    {
        _scoreText.text = score.ToString();
    }
    private void OnDestroy()
    {
        CuboidPickUp.CuboidPickedUp -= UpdateScore1;
    }
}
