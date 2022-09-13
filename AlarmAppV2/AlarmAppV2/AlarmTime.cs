using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmAppV2
{
    class AlarmTime
    {
        public string alarmTime { get; private set; }
        public string audioPath { get; private set; }
        public string alarmDateTime { get; private set; }
        public string alarmDateTimeShort { get; private set; }
        public string alarmInfoString { get; private set; }
        private bool active;

        public bool Active
        {
            get
            {
                return active;
            }
            set
            {
                active = value;
            }
        }        


        public AlarmTime(string _alarmTime, string _audioPath, string _alarmDateTime, string _alarmDateTimeShort, bool _active = true)
        {            
            alarmTime = _alarmTime;
            active = _active;
            audioPath = _audioPath;
            alarmDateTime = _alarmDateTime;
            alarmDateTimeShort = _alarmDateTimeShort;
            alarmInfoString = alarmDateTime + "-" + alarmTime;
        }

        public AlarmTime(AlarmTime newAlarmTime)
        {
            alarmTime = newAlarmTime.alarmTime;
            active = newAlarmTime.active;
            audioPath = newAlarmTime.audioPath;
            alarmDateTime = newAlarmTime.alarmDateTime;
            alarmDateTimeShort = newAlarmTime.alarmDateTimeShort;
            alarmInfoString = newAlarmTime.alarmDateTime + "-" + newAlarmTime.alarmTime;
        }

        public void SetAlarmDateTime(string newAlarmDateTime)
        {
            this.alarmDateTime = newAlarmDateTime;
        }

        public void SetAlarmDateTimeShort(string newAlarmDateTimeShort)
        {
            this.alarmDateTimeShort = newAlarmDateTimeShort;
        }
    }
}
