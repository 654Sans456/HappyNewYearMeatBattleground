using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStat : MonoBehaviour
{
    // Start is called before the first frame update

    int maxAtt = 5;
    float minAttS = 0f;
    float maxMs = 8f;
    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public static PlayerStat  Instance { get; private set; }

   public readonly int minAtt = 1;
    public readonly float maxAttS = 5f;
    public readonly float minMs = 3f;

    public Sprite on,off;

    int Aprice = 55;
    int MSprice = 55;
    int ASprice = 55;
    private void Update()
    {
        if (gameObject.name == "Скорость_бега") {
            if (GameManager.Scores>=MSprice) { gameObject.GetComponent<Button>().interactable = true; gameObject.GetComponent<Image>().sprite = on;  } else { gameObject.GetComponent<Button>().interactable = false; gameObject.GetComponent<Image>().sprite = off; }
            gameObject.transform.Find("Text (TMP)").GetComponent<TextMeshProUGUI>().text = PlayerController.moveSpeed.ToString();
        }
        if (gameObject.name == "Урона")
        {
            if (GameManager.Scores >= Aprice) { gameObject.GetComponent<Button>().interactable = true; gameObject.GetComponent<Image>().sprite = on; } else { gameObject.GetComponent<Button>().interactable = false; gameObject.GetComponent<Image>().sprite = off; }
            gameObject.transform.Find("Text (TMP)").GetComponent<TextMeshProUGUI>().text = PlayerController.attack.ToString();
        }
        if (gameObject.name == "Скрость_стрельбы")
        {
            if (GameManager.Scores >= ASprice) { gameObject.GetComponent<Button>().interactable = true; gameObject.GetComponent<Image>().sprite = on; } else { gameObject.GetComponent<Button>().interactable = false; gameObject.GetComponent<Image>().sprite = off; }
            gameObject.transform.Find("Text (TMP)").GetComponent<TextMeshProUGUI>().text = PlayerController.AttSpeed.ToString();
        }
        if (gameObject.name == "очки")
        {
            gameObject.GetComponent<TextMeshProUGUI>().text =  "Scrores: " + GameManager.Scores.ToString();
        }
        ;
    }
    public void ATTPlus()
    {
        if (PlayerController.attack != maxAtt) { PlayerController.attack += 1; GameManager.Scores -= Aprice; Aprice=Aprice*2; }
        //if (PlayerController.attack > 2) { PlayerShooting.Instance.bulletPrefab = }
    }
    public void MSPlus() { if (PlayerController.moveSpeed != maxMs) PlayerController.moveSpeed += 1f; GameManager.Scores -= MSprice; MSprice= MSprice*2; }
    public void ASPlus() { if (PlayerController.AttSpeed != minAttS) PlayerController.AttSpeed -= 1f; GameManager.Scores -= ASprice; ASprice = ASprice * 2; }
}

