int[] myArray = new int[10];

Random mass = new Random();
for(int x = 0;x < myArray.Length; x++)
{
    myArray[x] = mass.Next(30);
    
}