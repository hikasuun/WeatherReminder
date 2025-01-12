﻿/*
 * Notification.cs
 * Language : C#
 * Class for holding user notification options
 * in an object
 * January 2022 -
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WeatherNode
{
    [Serializable]
    public class Notification
    {
        private int id; // notification ID
        private int notificationHeat; // store notification hot temp
        private int notificationCold; // store notification cold temp
        private bool[] notificationOptions = new bool[3]; // store notifications as array of boolean val.
        /*
         * ARRAY SPACE      NOTIFICATION
         *           0      RAIN
         *           1      WIND
         *           2      FOG
         */

        // Constructor
        public Notification(int notiID, int notiHeat, int notiCold, bool[] notiOption)
        {
            setNotificationID(notiID);
            setNotificationHeat(notiHeat);
            setNotificationCold(notiCold);
            setNotificationOptions(notiOption);
        }

        public Notification() 
        {
            setNotificationID(11);
            setNotificationHeat((int)10);
        }

        
        // Getter and Setter utility functions
        public int getNotificationID()
        {
            return id;
        }
        public int getNotificationHeat()
        {
            return notificationHeat;
        }
        public int getNotificationCold()
        {
            return notificationCold;
        }
        public bool[] getNotificationOptions()
        {
            return notificationOptions;
        }
        public void setNotificationID(int notiID)
        {
            this.id = notiID;
        }
        public void setNotificationHeat(int notiHeat)
        {
            this.notificationHeat = notiHeat;
        }
        public void setNotificationCold(int notiCold)
        {
            this.notificationCold = notiCold;
        }
        public void setNotificationOptions (bool[] notiOptions)
        {
            this.notificationOptions = notiOptions;
        }
    }
}
