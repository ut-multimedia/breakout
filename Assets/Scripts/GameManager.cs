using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int _score;
    private int Score
    {
        get => _score;
        set
        {
            _score = value;  
            scoreText.text = "Score: " + _score;
        }
    }

    [SerializeField] private TextMeshProUGUI scoreText;
    


    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    
    public void OnBrickDestroyed()
    {
        Score++;
    }
    
}
