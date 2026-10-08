using F23.StringSimilarity;

namespace Lab1_SI2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The singularity is: {0}", new Cosine().Similarity("Hello, World!", "Hello, Class!"));
    }
}
