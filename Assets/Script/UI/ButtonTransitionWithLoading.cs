using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTransitionWithLoading : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        GameManager.Instance.NameScenes = sceneName;

        SceneManager.LoadScene("Loading");
    }
}
