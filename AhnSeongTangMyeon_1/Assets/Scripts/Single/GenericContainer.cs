public class GenericContainer<T>
{
    private T[] items; // 제너릭 배열 생성
    //private List<T> itemList;
    private int currentIndex = 0; // 배열 Index 생성
    
    public GenericContainer(int capacity)
    {
        items = new T[capacity];
    }

    public void Add(T item)
    {
        if(currentIndex < items.Length)
        {
            items[currentIndex] = item;
            currentIndex++;
        }
    }

    public T[] GetItems()
    {
        return items;
    }
}