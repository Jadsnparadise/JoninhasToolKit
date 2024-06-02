using FMOD.Studio;
using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JoninhasToolKit.Audio
{
    public static class FmodHelper
    {
        public static void PlayAudio(StudioEventEmitter Audio)
        {
            Audio.Play();
        }

        public static void PlayAudio(EventReference Audio)
        {
            RuntimeManager.CreateInstance(Audio).start();
        }

        public static void PlayAudio(EventReference Audio, EventInstance AudioInstance)
        {
            AudioInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            AudioInstance.release();
            AudioInstance = RuntimeManager.CreateInstance(Audio);
            AudioInstance.start();
        }

        public static void PlayOnlyIfEnded(StudioEventEmitter Audio)
        {
            Audio.EventInstance.getPlaybackState(out PLAYBACK_STATE state);
            if (state == PLAYBACK_STATE.PLAYING || state == PLAYBACK_STATE.SUSTAINING) return;
            Audio.Play();
        }

        public static void PlayOnlyIfEnded(EventReference Audio,EventInstance AudioInstance)
        {
            AudioInstance.getPlaybackState(out PLAYBACK_STATE state);
            if (state == PLAYBACK_STATE.PLAYING || state == PLAYBACK_STATE.SUSTAINING) return;
            AudioInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            AudioInstance.release();
            AudioInstance = RuntimeManager.CreateInstance(Audio);
            AudioInstance.start();
        }

    }
}

