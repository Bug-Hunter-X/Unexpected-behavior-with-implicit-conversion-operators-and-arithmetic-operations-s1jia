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

    public static MyClass operator +(MyClass a, int b) {
        return new MyClass(a.MyProperty + b);
    }
    public static MyClass operator +(MyClass a, MyClass b) {
        return new MyClass(a.MyProperty + b.MyProperty);
    }
}

public class Example {
    public static void Main(string[] args) {
        MyClass obj1 = 10; // Implicit conversion from int to MyClass
        int value = obj1;   // Implicit conversion from MyClass to int

        Console.WriteLine(value); // Output: 10
        Console.WriteLine(obj1.MyProperty); //Output: 10

        MyClass obj2 = 20;
        obj2 = obj2 + 5; // Now this works!
        Console.WriteLine(obj2.MyProperty); // Output: 25
        MyClass obj3 = 30;
        obj2 = obj2 + obj3; // This also works now
        Console.WriteLine(obj2.MyProperty); // Output: 55
    }
}