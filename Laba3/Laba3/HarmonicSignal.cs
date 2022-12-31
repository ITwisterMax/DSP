using System;

namespace Laba3
{
    class HarmonicSignal : Signal
    {
        double A, f, phi;

        public HarmonicSignal(double amplitude, double freq, double phase, int discrPoints,
            int min, int max, FilterType filterType) : base(min, max, filterType)
        {
            A = amplitude;
            n = discrPoints;
            f = freq;
            phi = phase;

            resotorePoints = n % 2 == 0 ? n / 2 : (n / 2 - 1);

            numHarm = 30;
            signal = GenerateSignal();
            sineSp = GetSineSpectrum();
            cosineSp = GetCosineSpectrum();
            amplSp = GetAmplSpectrum();
            phaseSp = GetPhaseSpectrum();
            restSignal = RestoreSignal();
            npSignal = RestoreNPSignal();
        }

        internal override double[] GenerateSignal()
        {
            double[] sign = new double[n];
            for (int i = 0; i <= n - 1; i++)
            {
                sign[i] = A * Math.Cos(2 * Math.PI * f * i / n + phi);
            }

            return sign;
        }
    }
}
