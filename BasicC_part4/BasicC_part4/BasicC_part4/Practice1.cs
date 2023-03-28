namespace BasicC_part4
{
    public class Practice1
    {        
        public int MyVariable {get; set;}
        private int _myPrivateVariable;

        //constructor
        public Practice1(){ 
            _myPrivateVariable = 20;
        }

        public int Add(int x)
        {
            // it adds x to my variable
            MyVariable = MyVariable + x;
            return MyVariable;
        }

        public void Remove(int remove)
        {
            _myPrivateVariable -= remove;
        }       
    }
}
