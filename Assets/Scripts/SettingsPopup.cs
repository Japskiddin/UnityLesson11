using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPopup : MonoBehaviour
{
    [SerializeField] private AudioClip sound; // ссылка на звуковой клип

    public void OnSoundToggle() { // кнопка переключает свойство mute диспетчера управления звуком
        Managers.Audio.soundMute = !Managers.Audio.soundMute;
        Managers.Audio.PlaySound(sound); // воспоизводится звуковой эффект при нажатии на кнопку
    }

    public void OnSoundValue(float volume) { // ползунок регулирует свойство volume диспетчера управления звуком
        Managers.Audio.soundVolume = volume;
    }
}
