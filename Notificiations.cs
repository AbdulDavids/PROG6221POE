﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221POE.Notifications
{
    public static class Notifications
    {
        public delegate void CalorieExceededNotification(string message); // delegate for calorie exceeded notification
    }
}