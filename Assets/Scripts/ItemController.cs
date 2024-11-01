using UnityEngine;
using UnityEngine.Video;

namespace DefaultNamespace
{
    public class ItemController : MonoBehaviour
    {
        public RenderTexture[] rts;
        public VideoClip[] clips;
        public Item[] items;
        public string[] names;

        public void Start()
        {
            for (var i = 0; i < items.Length; i++)
            {
                items[i].Init(rts[i], clips[i], names[i]);
            }
        }
    }
}