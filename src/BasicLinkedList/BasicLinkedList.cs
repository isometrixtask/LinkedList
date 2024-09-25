namespace BasicLinkedList;

public class BasicLinkedList<T>
{
    private BasicLinkedListItem<T>? _listItem;

    public void Insert(T item) {
        _listItem = new BasicLinkedListItem<T>(item);
    }

    public string PrintList() {
        if (_listItem is null) return string.Empty;

        return _listItem.Value?.ToString() ?? string.Empty;
    }
}