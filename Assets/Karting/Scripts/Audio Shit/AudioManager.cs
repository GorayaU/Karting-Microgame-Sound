using System;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

namespace Karting.Audio_Shit
{
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager Instance { get; private set; }

        private GameObject _player;
        private static EventInstance _musicEventInstance;
        private static EventInstance _engeineEventInstance;
        
        public static int numCheckpointsPassed = 0; 

        private void Awake()
        {
            _player = GameObject.FindGameObjectWithTag("Player");

            InitializeMusic(FmodEvents.Instance.Music);
            //InitializeEngine(FmodEvents.Instance.Engine);
            
            Instance = this;
            if (Instance == null)
            {
                Debug.LogError("More then one audio manager");
            }
        }

        // ReSharper disable Unity.PerformanceAnalysis
        public void PlayOneShot(EventReference sound, Vector3 worldPos)
        {
            RuntimeManager.PlayOneShot(sound, worldPos);
        }

        public StudioEventEmitter InitializeEventEmitter(GameObject emitterGameObject)
        {
            StudioEventEmitter emitter = emitterGameObject.GetComponent<StudioEventEmitter>();
            return emitter;
        }

        public EventInstance CreateEventInstance(EventReference eventReference)
        {
            EventInstance eventInstance = RuntimeManager.CreateInstance(eventReference);
            eventInstance.set3DAttributes(_player.transform.position.To3DAttributes());
            return eventInstance;
        }

        public void InitializeMusic(EventReference musicReference)
        {
            _musicEventInstance = CreateEventInstance(musicReference);
            _musicEventInstance.start();
        }
        
        public static void SetMusicParameter(string parameterName, float parameterValue)
        {
            _musicEventInstance.setParameterByName(parameterName, parameterValue);
        }

        private void InitializeEngine(EventReference engineReference)
        {
            _engeineEventInstance = CreateEventInstance(engineReference);
        }

        public static void SetEngineParameter(string parameterName, float parameterValue)
        {
            _engeineEventInstance.setParameterByName(parameterName, parameterValue);
        }
    }
}
