using UnityEngine;
using Slider = UnityEngine.UI.Slider;

namespace SwerveScript.MenuSwerve
{
    public class SoundManager : MonoBehaviour
    {
        [SerializeField] Slider volumeSlide;

        void Start()
        {
            if (!PlayerPrefs.HasKey("musicVolume"))
            {
                PlayerPrefs.SetFloat("musicVolume", 1);
                this.Load();
            }
            else
            {
                this.Load();
            }
        }
        public void ChangeVolume()
        {
            AudioListener.volume = this.volumeSlide.value; 
            this.Save();
        }

        private void Load()
        {
            this.volumeSlide.value = PlayerPrefs.GetFloat("musicVolume"); 
        }
        private void Save()
        {
            PlayerPrefs.SetFloat("musicVolume", this.volumeSlide.value);
        }
    }
}