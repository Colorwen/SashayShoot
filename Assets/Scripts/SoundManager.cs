using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
    //背景音乐编号
    public enum BGMusicNumber {
        None = 0,
        BGMusic_1 = 1,
        BGMusic_2 = 2,
        BGMusic_3 = 3,
        BGMusic_4 = 4,
        BGMusic_5 = 5,
        BGMusic_6 = 6

    }
    public static SoundManager Instance;
    public BGMusicNumber bGMusicNumber = BGMusicNumber.BGMusic_1;
    //音效扬声器
    public AudioSource effectSoundSpeaker;
    //语音扬声器
    public AudioSource soundSpeaker;
    //背景音乐扬声器
    public AudioSource bGMusicSpeaker;
    //落水声音扬声器
    public AudioSource waterFallSpeaker;
    // Use this for initialization
    void Awake() {
        Instance = this;
        SpeakerInit();
    }

    private void SpeakerInit() {
        effectSoundSpeaker = GameObject.Find("EffectSoundSpeaker").GetComponent<AudioSource>();
        soundSpeaker = GameObject.Find("SoundSpeaker").GetComponent<AudioSource>();
        bGMusicSpeaker = GameObject.Find("BGMusicSpeaker").GetComponent<AudioSource>();
        if((int)bGMusicNumber != 0) {
            bGMusicSpeaker.clip = Resources.Load("Sounds/PublicSounds/PublicBGMusic_" + (int)bGMusicNumber) as AudioClip;
            bGMusicSpeaker.Play();
        }

    }
    /// <summary>
    /// 播放语音声音
    /// </summary>
    public void PlaySound(AudioClip audio) {
        if(audio != null) {

            if(soundSpeaker.isPlaying) {
                soundSpeaker.Stop();
                soundSpeaker.clip = audio;
                soundSpeaker.Play();

            } else {
                soundSpeaker.clip = audio;
                soundSpeaker.Play();

            }

        }
    }

    /// <summary>
    /// 是否正在播放语音
    /// </summary>
    /// <returns></returns>
    public bool IsSoundSpeakerPlaying() {
        return (soundSpeaker.isPlaying);
    }
    /// <summary>
    /// 判断当前播放语音是否是同一剪辑
    /// </summary>
    /// <returns></returns>
    public bool IsSoundSpeakerPlayingTheSameClip(AudioClip _clip) {
        if(soundSpeaker.clip == null) {
            return false;
        } else {
            return (_clip == soundSpeaker.clip);
        }
    }

    /// <summary>
    /// 播放音效声音
    /// </summary>
    public void PlayEffectSound(AudioClip audio) {
        if(audio != null) {
            if(effectSoundSpeaker.isPlaying) {
                effectSoundSpeaker.Stop();
                effectSoundSpeaker.clip = audio;
                effectSoundSpeaker.Play();
            } else {
                effectSoundSpeaker.clip = audio;
                effectSoundSpeaker.Play();

            }
        }
    }
    /// <summary>
    /// 播放背景音乐
    /// </summary>
    public void PlayBGMusic(AudioClip audio) {
        if(audio != null) {
            if(bGMusicSpeaker.isPlaying) {
                bGMusicSpeaker.Stop();
                bGMusicSpeaker.clip = audio;
                bGMusicSpeaker.Play();
            } else {
                bGMusicSpeaker.clip = audio;
                bGMusicSpeaker.Play();

            }
        }
    }

    /// <summary>
    /// 播放落水声音
    /// </summary>
    public void PlayWaterFallSound(AudioClip audio) {
        if(audio != null && !waterFallSpeaker.isPlaying) {
            waterFallSpeaker.clip = audio;
            waterFallSpeaker.Play();
        }
    }


    /// <summary>
    /// 播放临时声音
    /// </summary>
    /// <param name="_audioClip">声音剪辑</param>
    /// <param name="_volum">声音音量</param>
    /// <returns>删除这个GameObject即可打断当前播放的声音</returns>
    static public GameObject PlayTempSound(AudioClip _audioClip, float _volume = 1f) 
    {
        if(_audioClip == null)
            return null;
        GameObject _tempSound = new GameObject("TempSound");
        _tempSound.AddComponent<AudioSource>();
        _tempSound.GetComponent<AudioSource>().clip = _audioClip;
        _tempSound.GetComponent<AudioSource>().volume = _volume;
        _tempSound.GetComponent<AudioSource>().Play();
        Destroy(_tempSound, _audioClip.length);
        return _tempSound;
    }

    /// <summary>
    /// 建斌添加该方法
    /// </summary>
    /// <param name="audio"></param>
    public void PlayEffectSoundOnce(AudioClip audio) {
        if(audio != null) {
            soundSpeaker.clip = audio;
            soundSpeaker.Play();
        }
    }
    ///// <summary>
    ///// 播放SGM舞台字典音效
    ///// </summary>
    ///// <param name="_dicKey"></param>
    ///// <param name="_volume"></param>
    ///// <returns></returns>
    //static public GameObject PlayFromStageSoundDic(string _dicKey, float _volume = 1f) 
    //{
    //    SGMStageManager _ssm = SGMStageManager.Instance;
    //    if(_ssm == null) {
    //        Debuger.LogWarning("SGMStageManager的实例找不到！");
    //        return null;
    //    }
    //    if(!_ssm.totalSoundsDic.ContainsKey(_dicKey)) {
    //        Debuger.LogWarning("字典内没有" + _dicKey + "音频！");
    //        return null;
    //    }
    //    GameObject _tempSound = new GameObject("TempSound");
    //    _tempSound.AddComponent<AudioSource>();
    //    var _clip = _ssm.totalSoundsDic[_dicKey];
    //    _tempSound.GetComponent<AudioSource>().clip = _clip;
    //    _tempSound.GetComponent<AudioSource>().volume = _volume;
    //    _tempSound.GetComponent<AudioSource>().Play();
    //    Destroy(_tempSound, _clip.length);
    //    return _tempSound;
    //}
}
