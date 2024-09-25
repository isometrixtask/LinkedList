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
}