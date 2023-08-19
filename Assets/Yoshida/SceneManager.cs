using UnityEngine;
public class SceneManager : MonoBehaviour
{
    public void SceneChange(string name)
    {
        print($"{name}SceneLoad");
        UnityEngine.SceneManagement.SceneManager.LoadScene(name);
    }
}
