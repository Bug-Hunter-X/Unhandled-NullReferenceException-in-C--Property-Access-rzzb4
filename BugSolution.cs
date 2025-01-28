public class ExampleClass
    {
        public int MyProperty { get; set; } = 0; // Explicit Initialization

        public void MyMethod()
        {
            //Console.WriteLine(MyProperty.ToString()); // No longer throws exception
            Console.WriteLine(MyProperty); //No longer throws exception
        }
    }

public class ExampleClass2
    {
        public int? MyProperty { get; set; } 

        public void MyMethod()
        {
            int value = MyProperty ?? 0; //Null check with null-coalescing operator
            Console.WriteLine(value);
        }
    }