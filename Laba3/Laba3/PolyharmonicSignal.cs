using System;

namespace Laba3
{
    class PolyharmonicSignal : Signal
    {
        double[] A, phi;
        double[] resA, resPhi;
        double f;

        public PolyharmonicSignal(double[] amplitudes, double freq, double[] phases, int discrPoints, 
            int min, int max, FilterType filterType) : base (min, max, filterType)
        {
            A = amplitudes;
            n = discrPoints;
            f = freq;
            phi = phases;

            resotorePoints = n % 2 == 0 ? n / 2 : (n / 2 - 1);

            numHarm = 30;

            resA = new double[numHarm];
            resPhi = new double[numHarm];

            Random rnd = new Random();
            for (int i = 0; i < numHarm - 1; i++)
            {
                resA[i] = A[rnd.Next(7)];
                resPhi[i] = phi[rnd.Next(6)];
            }

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
            Random rnd = new Random();
            for (int i = 0; i <= n - 1; i++)
            {
                double tm = 0;
                for (int j = 0; j <= numHarm - 1; j++)
                {
                     tm+= A[rnd.Next(7)]* Math.Cos(2 * Math.PI * f * i / n - phi[rnd.Next(6)]);
                }
                sign[i] = tm;
            }

            return sign;
        }
    }
}
