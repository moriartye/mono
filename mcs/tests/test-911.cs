// Compiler options: -r:test-911-lib.dll
public class A
{
    protected B b { get; set; }
    public void Foo()
    {
        b.Finalize();
    }
}

public class Test
{
        public static int Main ()
        {
                return 0;
        }
}
