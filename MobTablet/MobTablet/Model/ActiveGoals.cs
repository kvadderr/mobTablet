using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MobTablet.Model
{
    public class ActiveGoals
    {
        public int ID { get; set; }
        public bool isCounter { get; set; }
        public bool isSuccess { get; set; }
        public bool isFailed { get; set; }
        public bool isFire { get; set; }
        public Color progressColor { get; set; }
        public string Detail { get; set; }
        public int Coin { get; set; }
        public int Karma { get; set; }
        public double Progress { get; set; }
        public string Condition { get; set; }
        public string Time { get; set; }

    }
}
