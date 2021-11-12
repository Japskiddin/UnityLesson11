using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour, IGameManager
{
    [SerializeField] private AudioSource soundSource; // €чейка переменной на панели дл€ ссылки на новый источник звука
    public ManagerStatus status { get; private set; }
    private NetworkService _network;

    public float soundVolume { // свойство дл€ громкости с функцией чтени€ и функцией доступа
        get { return AudioListener.volume; } // реализуем функции чтени€/доступа с помощью AudioListener
        set { AudioListener.volume = value; }
    }

    public bool soundMute { // добавл€ем аналогичное свойство дл€ выключени€ звука
        get { return AudioListener.pause; }
        set { AudioListener.pause = value; }
    }

    public void Startup(NetworkService service) {
        Debug.Log("Audio manager starting...");
        _network = service;
        soundVolume = 1f; // 1 - полна€ громкость
        status = ManagerStatus.Started;
    }

    public void PlaySound(AudioClip clip) { // воспроизводим звуки, не имеющие другого источника
        soundSource.PlayOneShot(clip);
    }
}
