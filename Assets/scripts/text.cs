using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace TextEffect
{
    public class text : MonoBehaviour
    {

        public static string msg = "孤舟簑笠翁，獨釣寒江雪。";
        private Text textComp;
        public float startDelay = 2f;
        public float typeDelay = 0.01f;

        public static bool typing = false;

        public static bool typtriger = false;
        private Animator animat;
       

        void Awake()
        {
            textComp = GetComponent<Text>();
            animat = GameObject.Find("Canvas(Clone)").GetComponent<Animator>();
        }

        // Use this for initialization
        void Start()
        {

            StartCoroutine(TypeIn());

        }

        void Update()
        {
            if (typtriger)
                StartCoroutine(TypeIn());
        }

        private IEnumerator TypeIn()
        {
            typtriger = false;
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
}
