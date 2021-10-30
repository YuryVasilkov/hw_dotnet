using System;

namespace HW_08_02_01_AssemblyOne
{
    public class Motorcycle
    {
        public const ushort speedPublic = 1000;
        protected const ushort speedProtected = 900;
        internal const ushort speedInternal = 800;
        protected internal const ushort speedProtectedInternal = 700;
        private const ushort speedPrivate = 600;
        protected private const ushort speedProtectedPrivate = 600;

        public string namePublic = "Honda CBR1000RR-R FIREBLADE";
        protected string nameProtected = "Honda Gold Wing Tour DCT";
        internal string nameInternal = "Honda СB300R Neo Sports Cafe";
        protected internal string nameProtectedInternal = "Honda NC750X DCT";
        private string namePrivate = "Honda CMX1100 Rebel 2021 MT";
        protected private string nameProtectedPrivate = "Honda CB1000R Black Edition";

        public string NamePublic { get; set; }
        private string NamePrivate { get; set; }

        protected string NameProtected { get; set; }
        internal string NameInternal { get; set; }
        protected internal string NameProtectedInternal { get; set; }
        protected private string NameProtectedPrivate { get; set; }

        public void PublicStartEngine()
        {
            Console.WriteLine("Arrrrr");
        }
        private void PrivateStartEngine()
        {
            Console.WriteLine("Arrrrr");
        }
        protected void ProtectedStartEngine()
        {
            Console.WriteLine("Arrrrr");
        }
        internal void InternalStartEngine()
        {
            Console.WriteLine("Arrrrr");
        }
        protected internal void ProtectedInternalStartEngine()
        {
            Console.WriteLine("Arrrrr");
        }
        protected private void ProtectedPrivateStartEngine()
        {
            Console.WriteLine("Arrrrr");
        }
    }
}