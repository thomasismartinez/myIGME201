using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2_Q4_7
{
    static internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public abstract class Phone
    {
        private string phoneNumber;
        public string Address;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public abstract void Connect();
        public abstract void Disconnect();
    }

    //PHONE INTERFACE
    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }

    //ROTARY PHONE
    public class RotaryPhone : Phone, PhoneInterface
    {
        public void Answer() { }
        public void MakeCall() { }
        public void HangUp() { }
        public override void Connect() { }
        public override void Disconnect() { }
    }

    //PUSH BUTTON PHONE
    public class PushButtonPhone : Phone, PhoneInterface
    {
        public void Answer() { }
        public void MakeCall() { }
        public void HangUp() { }
        public override void Connect() { }
        public override void Disconnect() { }
    }

    //TARDIS
    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho
        {
            get { return whichDrWho; }
        }

        public string FemaleSideKick
        {
            get { return femaleSideKick; }
        }

        public void TimeTravel() { }

        public static bool operator ==(Tardis tardisA, Tardis tardisB)
        {
            if (tardisA.WhichDrWho == tardisB.WhichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Tardis tardisA, Tardis tardisB)
        {
            if (tardisA.WhichDrWho != tardisB.WhichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Tardis tardisA, Tardis tardisB)
        {
            if (tardisA.WhichDrWho < tardisB.WhichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Tardis tardisA, Tardis tardisB)
        {
            if (tardisA.WhichDrWho > tardisB.WhichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <=(Tardis tardisA, Tardis tardisB)
        {
            if (tardisA.WhichDrWho <= tardisB.WhichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(Tardis tardisA, Tardis tardisB)
        {
            if (tardisA.WhichDrWho >= tardisB.WhichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    } 

    //PHONE BOOTH
    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor() { }
        public void CloseDoor() { }
    }
}
