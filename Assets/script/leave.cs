using UnityEngine;
using UnityEngine.SceneManagement;

public class leave : MonoBehaviour {
    public int sid = 0;
    Animator animtor;
    void Start()
    {
        animtor = this.GetComponent<Animator>();
    }

    public void open()
    {
        animtor.SetInteger("title_state", 1);
    }
    public void jump()
    {
        SceneManager.LoadScene(sid, LoadSceneMode.Single);
    }
}
