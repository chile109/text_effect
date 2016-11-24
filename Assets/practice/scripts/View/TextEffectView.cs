using UnityEngine;
using strange.extensions.mediation.impl;
using UnityEngine.UI;
using strange.extensions.signal.impl;

namespace TextEffect
{
    public class TextEffectView : View
    {
        public Signal clickSignal = new Signal();

        public Text output;

        public void AddUI()
        {
            GameObject canvasClone = Instantiate(Resources.Load("Prefabs/Canvas")) as GameObject;
            canvasClone.transform.SetParent(transform);

            GameObject eventSystemClone = Instantiate(Resources.Load("Prefabs/EventSystem")) as GameObject;
            eventSystemClone.transform.SetParent(transform);

            output = canvasClone.GetComponentInChildren<Text>();
            //RectTransform trans = output.GetComponentInChildren<RectTransform>();
            //trans.anchoredPosition = new Vector2(0, 50);

            Button button = canvasClone.GetComponentInChildren<Button>();
            //trans = button.GetComponentInChildren<RectTransform>();
            //trans.anchoredPosition = new Vector2(0, 0);
            button.onClick.AddListener(clickSignal.Dispatch);//点击按钮信号分发出去

        }
    }
}
