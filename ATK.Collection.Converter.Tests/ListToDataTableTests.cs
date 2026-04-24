namespace ATK.Collection.Converter.Tests;
public class ListToDataTableTests
{
    [Fact]
    public void ListToDataTableConvert_Works()
    {
        var list = new List<TestUser>
        {
            new() { Name = "Name", Age = 10}
        };

        var dataTableFromList = list.Convert().To.DataTable;
        Assert.True(dataTableFromList.Rows.Count == list.Count);
    }

    [Fact]
    public void ListToDataFrameConvert_Works()
    {
        var list = new List<TestUser>
        {
            new() { Name = "Name", Age = 10, BirthDate = DateTime.Today}
        };

        var dataFrameFromList = list.Convert().To.DataFrame;
        Assert.True(dataFrameFromList.Rows.Count == list.Count);
    }

    internal class TestUser
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
    }
}