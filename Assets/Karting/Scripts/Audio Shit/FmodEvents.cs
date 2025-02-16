using FMODUnity;
using UnityEngine;

namespace Karting.Audio_Shit
{
    public class FmodEvents : MonoBehaviour
    {
        [field: Header("Music")]
        [field: SerializeField] public EventReference Music { get; private set; }
        
        [field: Header("Character Noises")]
        [field: SerializeField] public EventReference Engine { get; private set; }
        [field: SerializeField] public EventReference Brake { get; private set; }
        
        [field: Header("Injury Sounds")]
        [field: SerializeField] public EventReference WallHit { get; private set; }
        
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