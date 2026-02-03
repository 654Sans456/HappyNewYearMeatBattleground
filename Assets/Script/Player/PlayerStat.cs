using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    // Start is called before the first frame update

    
     
    public void ATTPlus() {
        PlayerController.attack+=1;
    }
    public void MSPlus() { PlayerController.moveSpeed += 1f; }
    public void ASPlus() { }
}
