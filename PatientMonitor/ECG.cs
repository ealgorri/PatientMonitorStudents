using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMonitor
{
    class ECG
    {
        public double amplitude = 0.0;
        public double frequency = 0;

        public ECG(double amplitude, double frequency)
        {
            this.amplitude = amplitude;
            this.frequency = frequency;
        }

        public double NextSample(double timeIndex)
        {
            const double HzToBeatsPerMin = 60.0;
            double sample;

            sample = Math.Cos(2 * Math.PI * (frequency / HzToBeatsPerMin) * timeIndex);
            sample *= amplitude;
            return (sample);
        }
    }
}

