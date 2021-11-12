using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPopup : MonoBehaviour
{
    [SerializeField] private AudioClip sound; // ������ �� �������� ����

    public void OnSoundToggle() { // ������ ����������� �������� mute ���������� ���������� ������
        Managers.Audio.soundMute = !Managers.Audio.soundMute;
        Managers.Audio.PlaySound(sound); // �������������� �������� ������ ��� ������� �� ������
    }

    public void OnSoundValue(float volume) { // �������� ���������� �������� volume ���������� ���������� ������
        Managers.Audio.soundVolume = volume;
    }
}
