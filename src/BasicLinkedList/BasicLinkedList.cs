namespace BasicLinkedList;

public class BasicLinkedList<T>
{
    private BasicLinkedListItem<T>? _head;

    public void Insert(T item) {

        var newListItem = new BasicLinkedListItem<T>(item);
        newListItem.Next = _head;
        _head = newListItem;
    }

    public void Delete() {
        _head = _head?.Next;
    }

    public string PrintList() {
        if (_head is null) return string.Empty;

        var currentListItem = _head;
        var outputString = $"{currentListItem.Value}";

        while (currentListItem?.Next != null) {
            currentListItem = currentListItem.Next;
            outputString += $", {currentListItem.Value}";
        }

        return outputString;
    }
}