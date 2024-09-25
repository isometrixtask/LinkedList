namespace BasicLinkedList;

internal class BasicLinkedListItem<T>(T value)
{
    public T Value { get; set; } = value;
    public BasicLinkedListItem<T>? Next { get; set; }
}