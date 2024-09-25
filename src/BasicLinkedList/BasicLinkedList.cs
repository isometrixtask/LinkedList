namespace BasicLinkedList;

public class BasicLinkedList<T>
{
    private BasicLinkedListItem<T>? _listItem;

    public void Insert(T item) {

        var newListItem = new BasicLinkedListItem<T>(item);
        newListItem.Next = _listItem;
        _listItem = newListItem;
    }

    public string PrintList() {
        if (_listItem is null) return string.Empty;

        var currentListItem = _listItem;
        var outputString = $"{currentListItem.Value}";

        while (currentListItem?.Next != null) {
            currentListItem = currentListItem.Next;
            outputString += $", {currentListItem.Value}";
        }

        return outputString;
    }
}