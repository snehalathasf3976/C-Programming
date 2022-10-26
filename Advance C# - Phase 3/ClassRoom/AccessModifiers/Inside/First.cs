using Outside;
namespace Inside
{
    public class First
    {
        public int Number1=10;
        private int Number2=20;
        public int OutNumber2 { get{return Number2 ;} }
        protected int Number3 = 30 ;
        internal int Number4=60;
        public int OutNumber5 {get{return OutNumber5;}}

    }
}