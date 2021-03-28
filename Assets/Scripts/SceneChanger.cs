using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static SceneChanger instance;

    public Animator anim;
    public float delay;

    private string scene;

    private void Start()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public static void ChangeScene(string sceneName)
    {
        instance.anim.Play("Out");
        instance.scene = sceneName;
        instance.Invoke("LoadScene", instance.delay);
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(scene);
        instance.anim.Play("In");
    }
}
