﻿using System;
using System.Collections.Generic;
using WatchFace.BasicElements;
using WatchFace.Models;

namespace WatchFace.Elements
{
    public class Time
    {
        public AmPmSwitch AmPm { get; set; }
        public TwoDigits Hours { get; set; }
        public TwoDigits Minutes { get; set; }
        public TwoDigits Seconds { get; set; }

        public static Time Parse(List<Parameter> descriptor)
        {
            if (descriptor == null)
                throw new ArgumentNullException(nameof(descriptor));

            var result = new Time();
            foreach (var parameter in descriptor)
                switch (parameter.Id)
                {
                    case 1:
                        result.Hours = TwoDigits.Parse(parameter.Children);
                        break;
                    case 2:
                        result.Minutes = TwoDigits.Parse(parameter.Children);
                        break;
                    case 3:
                        result.Seconds = TwoDigits.Parse(parameter.Children);
                        break;
                    case 4:
                        result.AmPm = AmPmSwitch.Parse(parameter.Children);
                        break;
                    default:
                        throw new InvalidParameterException(parameter);
                }
            return result;
        }
    }
}