using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;

namespace TextEffect
{
    public class TextEffectRoot : ContextView
    {

        void Awake()
        {
            context = new TextEffectContext(this);
        }
    }
}
