using System;

namespace Animals
{
    interface ISound
    {
        string Sound { get; }
        void ProduceSound(string sound);
    }
}
