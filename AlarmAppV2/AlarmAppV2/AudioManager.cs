using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AlarmAppV2
{
    class AudioManager
    {
        private static AudioManager instance;
        SoundPlayer soundPlayer = new SoundPlayer();

        private AudioManager() {}

        public static AudioManager GetInstance()
        {
            if (instance == null)
            {
                CreateInstance();
            }

            return instance;
        }

        private static void CreateInstance()
        {
            if (instance == null)
            {
                instance = new AudioManager();
            }
        }


        public async void PlayAlarmSound(string alarmSoundPath)
        {
            soundPlayer.SoundLocation = alarmSoundPath;
            try
            {
                soundPlayer.Play();
            }
            catch (Exception e)
            {
                //MessageBox.Show("sound not found = " + e.Message);
                Console.WriteLine(e.Message);
            }

            await Task.Delay(TimeSpan.FromSeconds(58));
            if (soundPlayer != null)
            {
                StopAlarmSound();
            }
        }

        public void StopAlarmSound() { 
            soundPlayer.Stop(); 
        }
    }
}
