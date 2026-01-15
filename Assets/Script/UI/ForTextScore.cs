using TMPro;
using UnityEngine;

public class ForTextScore : MonoBehaviour
{
    private TMP_Text textMeshPro;

    void Start()
    {
        textMeshPro = GetComponent<TMP_Text>();
    }

    void Update()
    {
        textMeshPro.text = "Score: " + GameManager.Instance.Score;
    }
}
