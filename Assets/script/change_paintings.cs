using UnityEngine;
using UnityEngine.UI;
public class change_paintings : MonoBehaviour {
    RawImage player;
    public Texture2D[] img;
    public static int p_id = 0;
    

    // Use this for initialization
    void Start () {
        p_id = 0;
        player = GetComponent<RawImage>();
    }
	

    public void right()
    {
        if (p_id < img.Length - 1)
        {
            p_id += 1;
        }
        else
        {
            p_id = 0;
        }
        player.texture = img[p_id];
        paint_name.n_id = p_id;
        paint_profile.m_id = p_id;
    }
    public void left()
    {
        if (p_id > 0)
        { 
            p_id -= 1;
        }
        else
        {
            p_id = img.Length - 1;
        }

        player.texture = img[p_id];
        paint_name.n_id = p_id;
        paint_profile.m_id = p_id;
    }
}
