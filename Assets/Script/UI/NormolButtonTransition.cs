using UnityEngine;
using UnityEngine.SceneManagement;

public class NormolButtonTransition : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
