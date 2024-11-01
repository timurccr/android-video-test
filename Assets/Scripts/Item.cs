using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Item : MonoBehaviour
{
    public RawImage image;
    public TMP_Text text;
    public VideoPlayer videoPlayer;
    
    public void Init(RenderTexture rt, VideoClip clip, string clipName)
    {
        text.text = clipName;
        image.texture = rt;
        videoPlayer.targetTexture = rt;
        
        videoPlayer.errorReceived += delegate (VideoPlayer videoPlayer, string message)
        {
            Debug.LogWarning($"[{clipName}] Play Movie Error: " + message);
        };

        videoPlayer.clip = clip;
        videoPlayer.Prepare();
        videoPlayer.Play();
    }
}
