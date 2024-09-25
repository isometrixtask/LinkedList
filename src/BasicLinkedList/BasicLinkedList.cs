namespace BasicLinkedList;

public class BasicLinkedList<T>
{
    private BasicLinkedListItem<T>? _head;

    public void Insert(T item, int position = 0) {

        var newListItem = new BasicLinkedListItem<T>(item);

        var listIsEmpty = _head is null;
        var isInsertingAtStart = position <= 0;
        if (listIsEmpty || isInsertingAtStart) {
            InsertNewHead(newListItem);
            return;
        }

        InsertAtPosition(newListItem, position);
    }

    private void InsertNewHead(BasicLinkedListItem<T> newListItem) {
        newListItem.Next = _head;
        _head = newListItem;
    }

    private void InsertAtPosition(BasicLinkedListItem<T> newListItem, int position)
    {
        var precedingItem = ItemAtPosition(position - 1);
        newListItem.Next = precedingItem?.Next;
        precedingItem.Next = newListItem;
    }

    public void Delete(int position = 0) {

        var listIsEmpty = _head is null;
        if (listIsEmpty) return;

        var deletingFromStart = position == 0;
        if (deletingFromStart) {
            DeleteHead();
            return;
        }

        DeleteAtPosition(position);
    }

    private void DeleteHead() {
        _head = _head?.Next;
    }

    private void DeleteAtPosition(int position) {

        var precedingItem = ItemAtPosition(position - 1);
        precedingItem.Next = precedingItem.Next?.Next;
    }

    private BasicLinkedListItem<T> ItemAtPosition(int position) {
        var currentPosition = 0;
        var currentItem = _head;

        while (currentPosition < position && currentItem?.Next is not null)
        {
            currentItem = currentItem.Next;
            currentPosition++;
        }

        return currentItem;
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