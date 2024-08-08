using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject videoAMD;
    public Button buttonAboutUs;
    public VideoPlayer videoPlayer;

    void Start()
    {
        // Menambahkan listener untuk buttonAboutUs
        buttonAboutUs.onClick.AddListener(OnButtonAboutUsClicked);

        // Menambahkan listener untuk event video selesai
        videoPlayer.loopPointReached += OnVideoFinished;
    }

    void OnButtonAboutUsClicked()
    {
        // Menonaktifkan MainMenu dan mengaktifkan VideoAMD
        mainMenu.SetActive(false);
        videoAMD.SetActive(true);

        // Memulai video
        videoPlayer.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        // Mengaktifkan kembali MainMenu dan menonaktifkan VideoAMD
        mainMenu.SetActive(true);
        videoAMD.SetActive(false);
    }
}