﻿
using Kandooz.InteractionSystem.Core;
using UnityEngine;
namespace Kandooz.InteractionSystem.Animations
{
    [System.Serializable]
    public struct FingerConstraints
    {
        public bool locked;
        [Range(0, 1)]
        public float min;
        public float max;
        public FingerConstraints(bool locked, float min, float max)
        {
            this.min = min;
            this.max = max;
            this.locked = locked;
        }
        public float GetConstrainedValue(float value)
        {
            if (locked)
            {
                return min;
            }
            return (max - min) * value + min;
        }
        /// <summary>
        /// Short for new FingerConstraints(false,0,1);
        /// </summary>
        public static FingerConstraints Free
        {
            get
            {


                return new FingerConstraints(false, 0, 1); ;
            }
        }
    }
    [System.Serializable]
    public struct HandConstraints
    {
        public FingerConstraints indexFingerLimits;
        public FingerConstraints middleFingerLimits;
        public FingerConstraints ringFingerLimits;
        public FingerConstraints pinkyFingerLimits;
        public FingerConstraints thumbFingerLimits;

        /// <summary>
        /// A non constrained Hand
        /// </summary>
        public static HandConstraints Free
        {
            get
            {
                var hand = new HandConstraints();
                hand.indexFingerLimits = FingerConstraints.Free;
                hand.middleFingerLimits = FingerConstraints.Free;
                hand.ringFingerLimits = FingerConstraints.Free;
                hand.pinkyFingerLimits = FingerConstraints.Free;
                hand.thumbFingerLimits = FingerConstraints.Free;
                return hand;
            }
        }
        public static HandConstraints Pointing
        {
            get
            {
                var hand = new HandConstraints();
                hand.indexFingerLimits = new FingerConstraints(false, 0, 1);
                hand.middleFingerLimits = new FingerConstraints(false, .3f, 1);
                hand.ringFingerLimits = new FingerConstraints(false, .3f, 1);
                hand.pinkyFingerLimits = new FingerConstraints(false, .3f, 1);
                hand.thumbFingerLimits = new FingerConstraints(false, .3f, 1);
                return hand;
            }
        }


        public FingerConstraints this[FingerName index]
        {
            get
            {
                var constraint = FingerConstraints.Free;
                switch (index)
                {
                    case FingerName.Thumb:
                        constraint = thumbFingerLimits;
                        break;
                    case FingerName.Index:
                        constraint = indexFingerLimits;
                        break;
                    case FingerName.Middle:
                        constraint = middleFingerLimits;
                        break;
                    case FingerName.Ring:
                        constraint = ringFingerLimits;
                        break;
                    case FingerName.Pinky:
                        constraint = pinkyFingerLimits;
                        break;
                }
                return constraint;
            }
            set { }
        }
    }
}