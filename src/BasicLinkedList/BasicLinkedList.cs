namespace BasicLinkedList;

public class BasicLinkedList<T>
{
    private BasicLinkedListItem<T>? _head;

    public void Insert(T item, int position = 0) {

        var newListItem = new BasicLinkedListItem<T>(item);

        if (position == 0) {
            newListItem.Next = _head;
            _head = newListItem;
            return;
        }

        var currentPosition = 0;
        var currentItem = _head;

        while (currentPosition < position - 1 && currentItem?.Next is not null) {
            currentItem = currentItem.Next;
            currentPosition++;
        }

        newListItem.Next = currentItem?.Next;
        currentItem.Next = newListItem;

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