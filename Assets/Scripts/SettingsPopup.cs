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

    public void OnMusicToggle() {
        Managers.Audio.musicMute = !Managers.Audio.musicMute;
        Managers.Audio.PlaySound(sound);
    }

    public void OnMusicValue(float volume) {
        Managers.Audio.musicVolume = volume;
    }

    public void OnPlayMusic(int selector) { // этот метод получает от кнопки численных параметр
        Managers.Audio.PlaySound(sound);

        switch (selector) { // вызываем для каждой кнопки свою музыкальную функцию в диспетчере AudioManager
            case 1:
                Managers.Audio.PlayIntroMusic();
                break;
            case 2:
                Managers.Audio.PlayLevelMusic();
                break;
            default:
                Managers.Audio.StopMusic();
                break;
        }
    }
}
