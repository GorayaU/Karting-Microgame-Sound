using FMODUnity;
using UnityEngine;

namespace Karting.Audio_Shit
{
    public class FmodEvents : MonoBehaviour
    {
        [field: Header("Ambiance")]
        [field: SerializeField] public EventReference Music { get; private set; }
        [field: SerializeField] public EventReference Clapping { get; private set; }
        [field: SerializeField] public EventReference Crows { get; private set; }
        [field: SerializeField] public EventReference Wind { get; private set; }
        
        [field: Header("Car Sounds")]
        [field: SerializeField] public EventReference Engine { get; private set; }
        [field: SerializeField] public EventReference Brake { get; private set; }
        [field: SerializeField] public EventReference Reverse { get; private set; }
        
        [field: Header("Misc")]
        [field: SerializeField] public EventReference WallHit { get; private set; }
        [field: SerializeField] public EventReference CheckpointPassed { get; private set; }
        [field: SerializeField] public EventReference Congrats { get; private set; }
        [field: SerializeField] public EventReference Lights { get; private set; }
        [field: SerializeField] public EventReference Winning { get; private set; }
        
        
        public static FmodEvents Instance { get; private set; }
        
        private void Awake()
        {
            Instance = this;
            if (Instance == null)
            {
                Debug.LogError("More then 1 instance");
            }
        }
    }
}