namespace DataStructures
{
  class FactorArray : IArray
  {
    private int actualCount = 0;
    public FactorArray()
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
        int newLength = 0;
        if(length == 0)
        {
          newLength = 1;
        }
        else
        {
          newLength = length * 2;
        }
        int[] newArray = new int[newLength];
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