using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using FMODUnity;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject menuPause;
    private bool pauseGame = false;

    [FMODUnity.EventRef]
    public string fmodEvent;  // Asigna el evento de FMOD desde el inspector.

    FMOD.Studio.EventInstance eventInstance;
    FMOD.Studio.TIMELINE_BEAT_PROPERTIES beatProperties;  // Mover la declaración aquí.

    private void Start()
    {
        eventInstance = FMODUnity.RuntimeManager.CreateInstance(fmodEvent);
        eventInstance.start();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        if (!pauseGame)
        {
            pauseGame = true;
            Time.timeScale = 0f;
            menuPause.SetActive(true);

            // Almacena la posición de la línea de tiempo antes de pausar.
            FMOD.Studio.PLAYBACK_STATE playbackState;
            eventInstance.getPlaybackState(out playbackState);
            if (playbackState == FMOD.Studio.PLAYBACK_STATE.PLAYING)
            {
                eventInstance.getTimelinePosition(out beatProperties.position);
                eventInstance.setPaused(true);
            }
        }
    }
    public void Resume()
    {
        pauseGame = false;
        Time.timeScale = 1f;
        menuPause.SetActive(false);

        // Reanuda desde la posición almacenada.
        eventInstance.setTimelinePosition(beatProperties.position);
        eventInstance.setPaused(false);
    }

    public void Exit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start");
    }
}
