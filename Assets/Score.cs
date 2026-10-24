using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private float score;

    private TextMeshProUGUI textMesh;


    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        //score += Time.deltaTime;
        textMesh.text = score.ToString("0");
    }

    public void AddScore(float enterPoints) {
    
        score += enterPoints;

    }

}
