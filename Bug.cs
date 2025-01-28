public class ExampleClass{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // This line will cause a NullReferenceException if MyProperty is not initialized
        Console.WriteLine(MyProperty.ToString()); 
    }
}