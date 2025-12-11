using UnityEngine;
using UnityEngine.Video;

public class VideoSwapToImage : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Material stillImageMaterial;
    private Renderer quadRenderer;

    void Start()
    {
        quadRenderer = GetComponent<Renderer>();

        // When the video finishes, call OnVideoFinished
        videoPlayer.loopPointReached += OnVideoFinished;
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        // Assign the still image material to the quad
        quadRenderer.material = stillImageMaterial;
    }
}
