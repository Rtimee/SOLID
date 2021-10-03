using UnityEngine;

public class AudioManager : MonoBehaviour
{
    #region Variables

    [SerializeField] private AudioSource[] _allSounds;

    #endregion

    #region Other Methods

    public void SetSoundState(int _soundIndex, bool _playSound)
    {
        if (_playSound)
            _allSounds[_soundIndex].Play();
        else
            _allSounds[_soundIndex].Stop();
    }

    #endregion
}
