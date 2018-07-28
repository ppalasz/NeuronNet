using System;

namespace NeuronNet
{
    public abstract class NeuronCell
    {
        private float[] _inputs;

        static NeuronCell()
        {

        }

        public NeuronCell(float[] inputs)
        {
            _inputs = inputs;
        }

        protected void Learn(float error, int synapsNumber)
        {
            throw new Exception("to do");
        }

        protected abstract void ProcessSynapsInput(float signalValue,int synapsNumber);

        protected abstract void ReProcessSynapsError(float signalError, int synapsNumber);
    }
}
