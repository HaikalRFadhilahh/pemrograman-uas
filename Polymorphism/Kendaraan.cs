namespace Polymorphism
{
    public class Mobil
    {
        private void checkmesin()
        {
            Console.WriteLine("Mesin Dalam Kondisi Baik");
        }
    
        private void checkbahanbakar()
        {
            Console.WriteLine("Bahan Bakar Cukup!");
        }

        private void startmobil()
        {
            Console.WriteLine("Menyalakan Mesin");
        }
        public virtual void checking()
        {
            checkmesin();
            checkbahanbakar();
            startmobil();
        }
    }

    public class Helicopter
    {
        private void checkmesin()
        {
            Console.WriteLine("Mesin Helicopter Dalam keadaan Baik!");
        }

        private void checkbahanbakar()
        {
            Console.WriteLine("Bahan Bakar Helicopter Cukup");
        }
    
        private void checkbaling2()
        {
            Console.WriteLine("Baling Baling Helicopter Dalam Keadaan Baik!");
        }
    
    
        public virtual void checkingheli()
        {
            checkmesin();
            checkbahanbakar();
            checkbaling2();
        }
    }

}