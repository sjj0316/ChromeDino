using TMPro;
using UnityEngine;

public class Scoer : MonoBehaviour

{
    [SerializeField]
    private TextMeshProUGUI ScoreText;

    private float score = 0;
    

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        ScoreText.text = ((int)score).ToString();
    }
}
