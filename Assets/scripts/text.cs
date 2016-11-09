using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class text : MonoBehaviour {

    public static string msg = "孤舟簑笠翁，獨釣寒江雪。";
    private Text textComp;
    public float startDelay = 2f;
    public float typeDelay = 0.01f;
    public static bool typing = false;
    public static bool typtriger = false;
    public Animator animat;

    void Awake()
    {
        textComp = GetComponent<Text>();
    }

    // Use this for initialization
    void Start()
    {

        StartCoroutine(TypeIn());

    }


    public  IEnumerator TypeIn()
    {
        animat.SetInteger("show_text", 0);
        yield return new WaitForSeconds(startDelay);
        for (int i = 0; i <= msg.Length; i++)
        {
            textComp.text = msg.Substring(0, i);
            
            yield return new WaitForSeconds(typeDelay);
        }
        animat.SetInteger("show_text", 1);
    }
}
