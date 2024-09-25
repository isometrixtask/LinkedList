using BasicLinkedList;

namespace BasicLinkedListTests;

public class BasicLinkedListTests
{
    [Fact]
    public void BasicLinkedList_PrintList_ReturnsEmptyString() {
        var list = new BasicLinkedList<int>();

        var expected = string.Empty;

        var result = list.PrintList();
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BasicLinkedList_Insert_ModifiesPrintListOutput() {
        var list = new BasicLinkedList<int>();
        list.Insert(42);

        var expected = "42";

        var result = list.PrintList();
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BasicLinkedList_InsertMultiple_ModifiesPrintListOutput()
    {
        var list = new BasicLinkedList<int>();
        list.Insert(42);
        list.Insert(9);

        var expected = "9, 42";

        var result = list.PrintList();
        Assert.Equal(expected, result);
    }
}