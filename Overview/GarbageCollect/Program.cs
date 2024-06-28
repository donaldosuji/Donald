// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Demonstration of Garbage Collection


// Retrieve and print the total memory allocated
Console.WriteLine($"Allocated memory is: {GC.GetTotalMemory(false)}");
Console.ReadLine();

// Call the function that allocates a large memory chunk
DoSomeBigOperation();

// Force a Garbage Collection after the function completes
GC.Collect();

// Retrieve and print the updated total memory amount
Console.WriteLine($"Allocated memory is: {GC.GetTotalMemory(false)}");
Console.ReadLine();

void DoSomeBigOperation()
{
    // create a large memory allocation that's only used in this function
    byte[] myArray = new byte[1000000];

    Console.WriteLine($"Allocated memory is: {GC.GetTotalMemory(false)}");
    Console.ReadLine();
}
