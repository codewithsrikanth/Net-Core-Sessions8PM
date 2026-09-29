using System;
using System.Runtime.InteropServices;

namespace CAAbstractClasses
{
    public interface ISample
    {
        void SwitchOn();
        void SwitchOff();
    }
    public class TV : ISample
    {
        public void SwitchOn() => Console.WriteLine("TV is On");
        public void SwitchOff() => Console.WriteLine("TV is Off");
    }
    public class AirConditioner : ISample
    {
        public void SwitchOn() => Console.WriteLine("AirConditioner is On");
        public void SwitchOff() => Console.WriteLine("AirConditioner is Off");
    }
}
