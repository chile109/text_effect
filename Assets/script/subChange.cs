using UnityEngine;
using UnityEngine.UI;

public class subChange : MonoBehaviour {

    RawImage player;
    public Texture2D[] img;
    public int index = 0;
    int sp;


    // Use this for initialization
    void Start()
    {
       
        player = GetComponent<RawImage>();
    }

    void Update()
    {
        sp = change_paintings.p_id + index;

        if (sp > img.Length - 1)
        {
            sp = 0;
        }
        if (sp < 0)
        {
            sp = img.Length - 1;
        }
        
        player.texture = img[sp];

    }

}
