using AlarmAppV2.UserController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmAppV2
{
    class AlarmTimeController
    {
        public delegate void OnUpdateAlarmList(List<AlarmTime> listOfAlarmTime);
        public event OnUpdateAlarmList onUpdateAlarmList;
        public string audioPath { get; private set; }

        List<AlarmTime> alarmTimeList = new List<AlarmTime>();
        TextFileManager tfm;
        string defaultAudioPath;
        bool exist;
        int arrayLen;       

        public AlarmTimeController()
        {
            AlarmControl.OnCheckBoxInteracted += OnCheckBoxChanged;
            AlarmControl.OnDeleteButton += DeleteAlarm;
            defaultAudioPath = AppContext.BaseDirectory;
            defaultAudioPath += @"Sounds\Crysis3SoundtrackNewYorkMemories.wav";
            audioPath = defaultAudioPath;
            tfm = new TextFileManager();
            GetAllAlarmFromText();
        }

        public bool UpdateTimer()
        {
            foreach (AlarmTime currentAlarmTime in alarmTimeList)
            {
                if (currentAlarmTime.Active == true && currentAlarmTime.alarmDateTimeShort == DateTime.Now.Date.ToShortDateString() && currentAlarmTime.alarmTime == DateTime.Now.ToShortTimeString())
                {
                    AudioManager.GetInstance().PlayAlarmSound(currentAlarmTime.audioPath);
                    //add an alarm after 7 days
                    SetAlarmOneWeekAfter(currentAlarmTime);                    
                    DeleteAlarm(currentAlarmTime.alarmInfoString);
                    //DeactiveAlarm(currentAlarmTime);                    
                    return true;
                }
            }
            return false;
        }

        public bool SetAlarm(string _hourComboBoxText, string _minComboBoxText, string _amPmComboBoxText, 
            string _dateTimePickerText, string _dateTimePickerShortText)
        {
            string targetDateTime = _dateTimePickerText;
            string targetDateTimeShort = _dateTimePickerShortText;
            string targetAlarmTime = _hourComboBoxText + ":" + _minComboBoxText + " " + _amPmComboBoxText;
            AlarmTime targetAlarm = new AlarmTime(targetAlarmTime, audioPath, targetDateTime, targetDateTimeShort, true);


            if (arrayLen != 0)
            {
                foreach (AlarmTime tempAlarmTime in alarmTimeList.ToArray())
                {
                    // check date
                    if (targetAlarm.alarmDateTime == tempAlarmTime.alarmDateTime)
                    {
                        // check hours and min.
                        if (targetAlarm.alarmTime != tempAlarmTime.alarmTime)
                        {
                            exist = false;
                        }
                        else
                        {
                            exist = true;
                            break;
                        }
                    }
                    else
                    {
                        exist = false;
                    }
                }

                // add alarm
                if (!exist)
                {
                    // add cause date times are different                            
                    SetAlarm(targetAlarm);
                    return true;

                }
                else
                {
                    return false;
                }

            }
            else
            {
                SetAlarm(targetAlarm);
                return true;
            }
        }

        public void ClearAlarmList()
        {
            if (arrayLen != 0)
            {
                alarmTimeList.Clear();
                tfm.DeleteAllAlarmOnTxt();
            }
            InvokeOnUpdateAlarmTimeList();
        }

        public void StopAlarmSound()
        {
            AudioManager.GetInstance().StopAlarmSound();
        }

        public string GetDefaultAudioPath()
        {
            return defaultAudioPath;
        }

        public void SetAudioPath(string newAudioPath)
        {
            if (newAudioPath != null)
            {
                audioPath = newAudioPath;
            }
        }

        public void SetDefaultAudioPath(string newDefaultAudioPath)
        {
            if (newDefaultAudioPath != null)
            {
                defaultAudioPath = newDefaultAudioPath;
                audioPath = defaultAudioPath;
            }
        }

        private void SetAlarmOneWeekAfter(AlarmTime alarmTime)
        {
            DateTime oneWeekAfterDateTime = DateTime.Now.AddDays(7);
            alarmTime.SetAlarmDateTime(oneWeekAfterDateTime.ToLongDateString());
            alarmTime.SetAlarmDateTimeShort(oneWeekAfterDateTime.ToShortDateString());
            AlarmTime newAlarmTime = new AlarmTime(alarmTime);
            SetAlarm(newAlarmTime);
        }

        private void SetAlarm(AlarmTime targetAlarm)
        {            
            tfm.AddAnAlarmToFile(targetAlarm);
            alarmTimeList.Add(targetAlarm);            
            ArrangeList();
            InvokeOnUpdateAlarmTimeList();

            audioPath = defaultAudioPath;            

            arrayLen++;
        }

        private void ArrangeList()
        {
            alarmTimeList = alarmTimeList.OrderBy(e => e.alarmTime).ThenBy(e => e.alarmTime).ToList();
        }

        private void DeleteAlarm(string alarmInfo)
        {
            foreach (AlarmTime tempAlarmTime in alarmTimeList)
            {
                if (tempAlarmTime.alarmInfoString == alarmInfo)
                {
                    alarmTimeList.Remove(tempAlarmTime);
                    arrayLen--;
                    tfm.DeleteAllAlarmOnTxt();
                    AddAllAlarmToText();
                    break;
                }
            }
            InvokeOnUpdateAlarmTimeList();
        }

        private void DeactiveAlarm(AlarmTime alarmTime)
        {
            alarmTime.Active = false;
            InvokeOnUpdateAlarmTimeList();
        }

        private void OnCheckBoxChanged(string infoString, bool _active)
        {
            foreach (AlarmTime tempAlarmTime in alarmTimeList)
            {
                if (tempAlarmTime.alarmInfoString == infoString)
                {
                    tempAlarmTime.Active = _active;
                }
            }
        }

        private void InvokeOnUpdateAlarmTimeList()
        {
            if (onUpdateAlarmList != null)
            {
                onUpdateAlarmList.Invoke(alarmTimeList);
            }
        }

        private async void GetAllAlarmFromText()
        {
            string[] alarmListOfTxt = tfm.GetAllLines();
            if (alarmListOfTxt != null)
            {
                foreach (string currentAlarmOnTxt in alarmListOfTxt)
                {
                    string[] splittedAlarmTxt = currentAlarmOnTxt.Split('*');
                    alarmTimeList.Add(new AlarmTime(splittedAlarmTxt[0], splittedAlarmTxt[1], splittedAlarmTxt[2],
                        splittedAlarmTxt[3]));
                    arrayLen++;
                }
            }
            await Task.Delay(TimeSpan.FromSeconds(1));

            ArrangeList();
            InvokeOnUpdateAlarmTimeList();
        }

        private void AddAllAlarmToText()
        {
            foreach (AlarmTime alarmTime in alarmTimeList)
            {
                tfm.AddAnAlarmToFile(alarmTime);
            }
        }
    }
}
