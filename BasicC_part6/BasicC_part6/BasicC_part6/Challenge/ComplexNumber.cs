namespace BasicC_part6.Challenge
{
    public class ComplexNumber
    {
        public int RealPart { get; set; }
        public int ImaginaryPart { get; set; }

        public ComplexNumber(int realpart, int imaginaryPart)
        {
            RealPart = realpart;
            ImaginaryPart = imaginaryPart;
        }

        public override string ToString()
        {
            return RealPart + " " + ImaginaryPart + "i";
        }
    }
}
