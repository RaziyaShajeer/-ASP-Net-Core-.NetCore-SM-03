string[] candidate = new string[] { "candiadte A,CANDIDATE B,CANDIDATE C,CANDIDATE D " };
int[] votes = new int[candidate.Length];
Console.WriteLine("enter number of candidates");
int numcand = Convert.ToInt32(Console.ReadLine());
string[] candidates = new string[numcand];
int[] vote = new int[numcand];
int totalvotes = 0;
int maxvote = 0;
for (int i = 0; i < numcand; i++)
{
    Console.WriteLine("enter candidate");
    candidates[i] = Console.ReadLine();
}
for (int i = 0; i < numcand; i++)
{
    Console.WriteLine("enetr the number of votes each candidate");
    vote[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (int elements in vote)
{

    totalvotes += elements;

}
Console.WriteLine($"total number of votes{totalvotes}");
for (int i = 0; i < vote.Length; i++)
{
    if (vote[i] > maxvote)
    {
        maxvote = vote[i];
    }
}
Console.WriteLine($"the highest vote is {maxvote}");
