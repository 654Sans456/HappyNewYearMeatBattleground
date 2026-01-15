using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForLouding : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene(GameManager.Instance.NameScenes);
    }
}
