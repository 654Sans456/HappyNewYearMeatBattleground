using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStat : MonoBehaviour
{
    // Start is called before the first frame update

    public int maxAtt = 6;
    public float maxMs = 10f;
    public float maxAttS = 20f;
    public void ATTPlus()
    {
        if (PlayerController.attack != maxAtt) { PlayerController.attack += 1; }
    }
    public void MSPlus() { if (PlayerController.moveSpeed != maxMs) PlayerController.moveSpeed += 1f; }
    public void ASPlus() { if (PlayerController.AttSpeed != maxAttS) PlayerController.AttSpeed += 1f; }
}

