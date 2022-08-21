namespace Polymorphism
{
    public class NissanSkylineR34 : Mobil
    {
        public override void checking()
        {
            header();
            base.checking();
            noss();
        }

        private void noss()
        {
            Console.WriteLine("Gunakan Nitrous....");
        }

        private void header()
        {
            Console.WriteLine("Nissan Skyline R34 Car Started!!!");
        }
    }

    public class Leviathan : Helicopter
    {
        public override void checkingheli()
        {
            Console.WriteLine("Leviathan Helicopter Prepared.....");
            base.checkingheli();
            magnet();
            angkut();
        }

        private void magnet()
        {
            Console.WriteLine("Leviathan Magnet Prepared.....");
        }
    
        private void angkut()
        {
            Console.WriteLine("Leviatahan Lift Car..!");
        }
    }
}