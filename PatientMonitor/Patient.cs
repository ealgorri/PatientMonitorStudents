using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMonitor
{
    internal class Patient
    {
        ECG ecg;

        public double ECGAmplitude { get => ecg.Amplitude; set => ecg.Amplitude = value; }
        public double ECGFrequency { get => ecg.Frequency; set => ecg.Frequency = value; }

        public Patient(double ampltude, double frequency)
        {
            ecg = new ECG(ampltude, frequency);
        }
        public double NextSample(double timeIndex)
        {
            return ecg.NextSample(timeIndex);
        }
    }
}
