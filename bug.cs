public class MyClass {
    public int MyProperty { get; set; }

    public MyClass(int value) {
        MyProperty = value;
    }

    public static implicit operator int(MyClass obj) {
        return obj.MyProperty;
    }

    public static implicit operator MyClass(int value) {
        return new MyClass(value);
    }
}

public class Example {
    public static void Main(string[] args) {
        MyClass obj1 = 10; // Implicit conversion from int to MyClass
        int value = obj1;   // Implicit conversion from MyClass to int

        Console.WriteLine(value); // Output: 10
        Console.WriteLine(obj1.MyProperty); //Output: 10

        MyClass obj2 = 20;
        obj2 = obj2 + 5; //Error occurs here
        Console.WriteLine(obj2.MyProperty); //This line will not execute due to error above
    }
}