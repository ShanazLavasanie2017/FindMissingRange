namespace MissingValues
{
    public class Program
    {
        static void Main(string[] args)
        {
            var curArr1 = new List<int>() { 1, 5 };
            var curArr2 = new List<int>() { 7, 3 };
            var curArr3 = new List<int>() { 1, 2 };
            var curArr4 = new List<int>();
            var curArr5 = new List<int>() { 1, 3, 5 };
            var curArr6 = new List<int>() { 4, 2, 9 };

            //var allFounded = FindMissingNumber.FindMissing(curArr6);
            var allFounded = FindMissingNumber.FindMissingRangedNumber(curArr2);


            if (allFounded.Count() == 0)
            {
                Console.WriteLine("There is no missing value!");
            }
            foreach (var founded in allFounded)
            {
                Console.WriteLine($"Founded {founded}"); 
            }
            Console.ReadLine();
        }

        
    }
}