namespace DataStructures
{
  class VectorArray : IArray
  {
    private int actualCount = 0;
    private static int increment = 1000;
    public VectorArray()
    {
      array  = new int[0];
    }
    public int size()
    {
      return actualCount;
    }
    public bool isEmpty()
    {
      return size() == 0;
    }
    public int get(int index)
    {
      return array[index];
    }
    public void put(int item)
    {
      int length = array.Length;
      if(length > actualCount)
      {
        array[actualCount] = item;
      }
      else
      {
        int[] newArray = new int[length + increment];
        for(int i=0; i<length; i++ )
        {
          newArray[i] = array[i];
        }
        newArray[length] = item;

        array = newArray;
      }
      actualCount++;
    }

    private int[] array;
  }
}