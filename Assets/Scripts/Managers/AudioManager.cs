using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour, IGameManager
{
    [SerializeField] private AudioSource soundSource; // ������ ���������� �� ������ ��� ������ �� ����� �������� �����
    public ManagerStatus status { get; private set; }
    private NetworkService _network;

    public float soundVolume { // �������� ��� ��������� � �������� ������ � �������� �������
        get { return AudioListener.volume; } // ��������� ������� ������/������� � ������� AudioListener
        set { AudioListener.volume = value; }
    }

    public bool soundMute { // ��������� ����������� �������� ��� ���������� �����
        get { return AudioListener.pause; }
        set { AudioListener.pause = value; }
    }

    public void Startup(NetworkService service) {
        Debug.Log("Audio manager starting...");
        _network = service;
        soundVolume = 1f; // 1 - ������ ���������
        status = ManagerStatus.Started;
    }

    public void PlaySound(AudioClip clip) { // ������������� �����, �� ������� ������� ���������
        soundSource.PlayOneShot(clip);
    }
}
