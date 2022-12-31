using System;

namespace Laba3
{
    abstract class Signal
    {
        internal int n;
        internal double[] signal, restSignal, npSignal;
        internal double[] sineSp, cosineSp;
        internal double[] amplSp, phaseSp;
        internal int numHarm = 100;
        internal int min, max;
        internal FilterType filterType;
        internal int resotorePoints;

        public double[] signVal { get { return signal; } }
        public double[] amplSpectrum { get { return amplSp; } }
        public double[] phaseSpectrum { get { return phaseSp; } }
        public double[] restoredSignal { get { return restSignal; } }
        public double[] restorednonphasedSignal { get { return npSignal; } }

        public Signal(int min, int max, FilterType filterType)
        {
            this.min = min;
            this.max = max;
            this.filterType = filterType;

        }

        public void reDrawSignal(int min, int max, FilterType filterType)
        {
            this.min = min;
            this.max = max;
            this.filterType = filterType;

            sineSp = GetSineSpectrum();
            cosineSp = GetCosineSpectrum();
            amplSp = GetAmplSpectrum();
            phaseSp = GetPhaseSpectrum();
            restSignal = RestoreSignal();
            npSignal = RestoreNPSignal();
        }

        internal virtual double[] GenerateSignal()
        {
            return null;
        }

        internal double[] GetSineSpectrum()
        {
            double[] values = new double[numHarm];
            for (int j = 0; j <= numHarm - 1; j++)
            {
                double val = 0;
                for (int i = 0; i <= n - 1; i++)
                {
                    val += signal[i] * Math.Sin(2 * Math.PI * i * j / n);
                }
                values[j] = 2 * val / n;
            }

            return values;
        }

        internal double[] GetCosineSpectrum()
        {
            double[] values = new double[numHarm];
            for (int j = 0; j <= numHarm - 1; j++)
            {
                double val = 0;
                for (int i = 0; i <= n - 1; i++)
                {
                    val += signal[i] * Math.Cos(2 * Math.PI * i * j / n);
                }
                values[j] = 2 * val / n;
            }

            return values;
        }

        internal double[] GetAmplSpectrum()
        {
            double[] values = new double[numHarm];
            double[] temper = new double[numHarm];
            double tempValue;

            for (int j = 0; j <= numHarm - 1; j++)
            {
                tempValue = Math.Sqrt(Math.Pow(sineSp[j], 2) + Math.Pow(cosineSp[j], 2));
                temper[j] = tempValue;
                switch (filterType)
                {
                    case FilterType.MinMax:
                        values[j] = (j > max && j < min) ? tempValue : 0;
                        break;
                    case FilterType.Max:
                        values[j] = j < max ? 0 : tempValue;
                        break;
                    case FilterType.Min:
                        values[j] = j > min ? 0 : tempValue;
                        break;
                    case FilterType.none:
                        values[j] = tempValue;
                        break;
                }
            }

            return values;
        }

        internal double[] GetPhaseSpectrum()
        {
            double[] values = new double[numHarm];
            for (int j = 0; j <= numHarm - 1; j++)
            {
                values[j] = Math.Atan(sineSp[j] / cosineSp[j]);
            }

            return values;
        }

        internal double[] RestoreSignal()
        {         
            double[] values = new double[resotorePoints];
            int temp = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                double val = 0;
                for (int j = 0; j <= numHarm - 1; j++)
                {
                    val += amplSp[j] * Math.Cos(2 * Math.PI * i * j / n - phaseSp[j]);
                }
                if (i % 2 == 0)
                {
                    values[temp] = val;
                    temp++;
                }
            }

            return values;
        }
        
        internal double[] RestoreNPSignal()
        {
            double[] values = new double[resotorePoints];
            int temp = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                double val = 0;
                for (int j = 0; j <= numHarm - 1; j++)
                {                             
                    val += amplSp[j] * Math.Cos(2 * Math.PI * i * j / n);
                }
                if (i % 2 == 0)
                {
                    values[temp] = val;
                    temp++;
                }
            }

            return values;
        }
    }
}
