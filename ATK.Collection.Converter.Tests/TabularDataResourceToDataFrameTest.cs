using ATK.Collection.Converter;
using Microsoft.DotNet.Interactive.Formatting.TabularData;

namespace ATK.Collection.Converter.Tests;
public class TabularDataResourceToDataFrameTest
{
    [Fact]
    public void Convert_Works()
    {
        var tableSchema = new TableSchema();
        var data = Array.Empty<IEnumerable<KeyValuePair<string, object>>>();
        var tabularData = new TabularDataResource(tableSchema, data);
        var dataFrame = tabularData.Convert().To.DataFrame;
        Assert.NotNull(dataFrame);
    }
}