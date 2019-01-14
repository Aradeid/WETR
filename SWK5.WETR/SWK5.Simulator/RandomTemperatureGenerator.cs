using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SWK5.Simulator
{
    class RandomTemperatureGenerator
    {
        #region Local Params
        private int delay; // delay between generation in miliseconds
        private ICollection<double> collection; // collection to keep generated numbers in
        private bool running = false;
        #endregion

        #region Generator Settings
        readonly int maxStepSize = 5; // how big can the difference between 2 values be?
        readonly int maxTemp = 45; // upper limit of value
        readonly int minTemp = -25; // lower limit of value
        readonly int tempLimitMargin = 6; // soft point at which value has to be forcefully corrected
        readonly int corrVal = 2; // minimal value to be inserted on forced correction
        readonly int maxSeriesSize = 5; // soft point at which growth direction is switched
        readonly int seriesSizeMargin = 2; // random value to make sign switching more natural
        #endregion

        #region Random Number Generator
        private int NextVal
        {
            get
            {
                int forcedVal = 0;
                int newSign;
                if (prevVal < minTemp + defaultGenerator.Next(0, tempLimitMargin))
                {
                    newSign = 1;
                    forcedVal = corrVal + 1;
                } else if (prevVal > maxTemp  - defaultGenerator.Next(0, tempLimitMargin))
                {
                    newSign = -1;
                    forcedVal = corrVal + 1;
                } else
                {
                    newSign = seriesSign * (int)Math.Pow(-1, Math.Floor((double)((seriesLength + defaultGenerator.Next(0, seriesSizeMargin + 1)) / maxSeriesSize)));
                }

                int newVal = prevVal + newSign * (int)Math.Floor(Math.Sqrt(defaultGenerator.Next(0, (int)Math.Pow(maxStepSize + 1, 2))) - 1 + corrVal);

                newSign = (newVal > prevVal) ? 1 : -1; // needs to be recalculated as in random sign scenario the sign can be changed
                if ((newSign == seriesSign) || (prevVal == newVal))
                {
                    ++seriesLength;
                } else
                {
                    seriesLength = 1;
                }

                // save new values
                seriesSign = newSign;
                prevVal = newVal;

                return prevVal;
            }
        }
        private Random defaultGenerator = new Random();
        private int prevVal;
        private int seriesLength = 1;
        private int seriesSign = 1;
        #endregion

        public RandomTemperatureGenerator(ICollection<double> collection, int delay = 1000)
        {
            this.collection = collection;
            this.delay = delay;

            prevVal = defaultGenerator.Next(0, 25);
        }

        public void Start()
        {
            running = true;
            Task.Factory.StartNew(() =>
            {
                while (running) // SOMEBODY STOP ME
                {
                    Thread.Sleep(delay);
                    collection.Add(NextVal);
                }
            });
        }

        public void Stop()
        {
            running = false;
        }
    }
}
