int x = 10;
Action closure = () =>
{
     Console.WriteLine("The value of the non-local variable x is: {0}", x);
};
closure();