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
            Tardis blueBox = new Tardis();
            PhoneBooth redBox = new PhoneBooth();

            UsePhone(blueBox);
            UsePhone(redBox);
        }

        static void UsePhone(object obj)
        {
            // set obj as a phone
            PhoneInterface phone = (PhoneInterface)obj;

            // make call and hang up
            phone.MakeCall();
            phone.HangUp();

            // if phone booth then open door
            if (phone is PhoneBooth)
            {
                PhoneBooth booth = (PhoneBooth)phone;
                booth.OpenDoor();
            }

            // if tardis the time travel
            if ( phone is Tardis )
            {
                Tardis tardis = (Tardis)phone;
                tardis.TimeTravel();
            }
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
            // if the doctors are the same return true
            if (tardisA.WhichDrWho == tardisB.WhichDrWho) { return true; }

            // otherwise return false
            else { return false; }
        }

        public static bool operator !=(Tardis tardisA, Tardis tardisB)
        {
            // it the doctors are not the same return true
            if (tardisA.WhichDrWho != tardisB.WhichDrWho) { return true; }

            // otherwise return false
            else { return false; }
        }

        public static bool operator <(Tardis tardisA, Tardis tardisB)
        {
            // if doctor A is not 10 and B is then return true
            if (tardisA.WhichDrWho != 10 && tardisB.WhichDrWho == 10) { return true; }

            // if doctor A is 10 and B is not then return false
            else if (tardisA.WhichDrWho == 10 && tardisB.WhichDrWho != 10) { return false; }

            // if doctor A is less than B
            else if (tardisA.WhichDrWho < tardisB.WhichDrWho) { return true; }

            // otherwise return false
            else { return false; }
        }

        public static bool operator >(Tardis tardisA, Tardis tardisB)
        {
            // if doctor A is 10 and B is not then return true
            if (tardisA.WhichDrWho == 10 && tardisB.WhichDrWho != 10) { return true; }

            // if doctor A is not 10 and B is the return false
            else if (tardisB.WhichDrWho == 10 && tardisA.WhichDrWho != 10) { return false; }

            // if doctor A is greater than B then return true
            else if (tardisA.WhichDrWho > tardisB.WhichDrWho) { return true; }

            // otherwise return false
            else { return false; }
        }

        public static bool operator <=(Tardis tardisA, Tardis tardisB)
        {
            // if doctor A is not 10 and B is then return true
            if (tardisA.WhichDrWho != 10 && tardisB.WhichDrWho == 10) { return true; }

            // if doctor A is 10 and B is not then return false
            else if (tardisA.WhichDrWho == 10 && tardisB.WhichDrWho != 10) { return false; }

            // if doctor A is less than or equal to B then return true
            if (tardisA.WhichDrWho <= tardisB.WhichDrWho) { return true; }

            // otherwise return false
            else { return false; }
        }

        public static bool operator >=(Tardis tardisA, Tardis tardisB)
        {
            // if doctor A is not 10 and B is then return true
            if (tardisA.WhichDrWho != 10 && tardisB.WhichDrWho == 10) { return true; }

            // if doctor A is 10 and B is not then return false
            else if (tardisA.WhichDrWho == 10 && tardisB.WhichDrWho != 10) { return false; }

            // if doctor A is greater than or equal to B then return true
            if (tardisA.WhichDrWho >= tardisB.WhichDrWho) { return true; }

            // otherwise return false
            else { return false; }
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
