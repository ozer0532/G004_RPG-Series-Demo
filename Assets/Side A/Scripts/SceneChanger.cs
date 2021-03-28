using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tutorial
{
    public class SceneChanger : MonoBehaviour
    {
        public static SceneChanger instance;

        public float delay;
        public Animator anim;

        private int scene;

        void Start()
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

        public static void ChangeScene(int scene)
        {
            instance.anim.Play("Out");
            instance.scene = scene;
            instance.Invoke(nameof(LoadScene), instance.delay);
        }

        public void LoadScene()
        {
            SceneManager.LoadScene(scene);
            instance.anim.Play("In");
        }
    }
}
