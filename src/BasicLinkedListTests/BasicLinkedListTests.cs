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

    [Fact]
    public void BasicLinkedList_InsertAtEnd_OrderedCorrectly()
    {
        var list = new BasicLinkedList<int>();
        list.Insert(42);
        list.Insert(9, 1);

        var expected = "42, 9";

        var result = list.PrintList();
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BasicLinkedList_InsertInMiddle_OrderedCorrectly()
    {
        var list = new BasicLinkedList<int>();
        list.Insert(42);
        list.Insert(9, 1);
        list.Insert(8, 1);

        var expected = "42, 8, 9";

        var result = list.PrintList();
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BasicLinkedList_InsertAtOutOfRangePosition_InsertsAtEnd()
    {
        var list = new BasicLinkedList<int>();
        list.Insert(42);
        list.Insert(9, 100);

        var expected = "42, 9";

        var result = list.PrintList();
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BasicLinkedList_InsertAtOutOfRangePosition_InsertsAtStart()
    {
        var list = new BasicLinkedList<int>();
        list.Insert(42);
        list.Insert(9, -100);

        var expected = "9, 42";

        var result = list.PrintList();
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BasicLinkedList_DeleteFromStart_RemovesSpecifiedItem()
    {
        var list = new BasicLinkedList<int>();
        list.Insert(42);
        list.Insert(9);
        list.Delete();

        var expected = "42";

        var result = list.PrintList();
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BasicLinkedList_DeleteFromMiddle_RemovesSpecifiedItem()
    {
        var list = new BasicLinkedList<int>();
        list.Insert(42);
        list.Insert(9, 1);
        list.Insert(8, 1);
        list.Delete(1);

        var expected = "42, 9";

        var result = list.PrintList();
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BasicLinkedList_DeleteFromEnd_RemovesSpecifiedItem()
    {
        var list = new BasicLinkedList<int>();
        list.Insert(42);
        list.Insert(9);
        list.Delete(1);

        var expected = "9";

        var result = list.PrintList();
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BasicLinkedList_DeleteOutOfRangePositionLow_DoesNotModifyList()
    {
        var list = new BasicLinkedList<int>();
        list.Insert(42);
        list.Delete(-100);

        var expected = "42";

        var result = list.PrintList();
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BasicLinkedList_DeleteOutOfRangePositionHigh_DoesNotModifyList()
    {
        var list = new BasicLinkedList<int>();
        list.Insert(42);
        list.Delete(100);

        var expected = "42";

        var result = list.PrintList();
        Assert.Equal(expected, result);
    }
}