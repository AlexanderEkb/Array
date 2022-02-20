namespace DataStructures
{
  class SingleArray : IArray
  {
    public SingleArray()
    {
      array  = new int[0];
    }
    public int size()
    {
      return array.Length;
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
      int length = size();
      int[] newArray = new int[length + 1];
      for(int i=0; i<length; i++ )
      {
        newArray[i] = array[i];
      }
      newArray[length] = item;

      array = newArray;
    }

    private int[] array;
  }
}