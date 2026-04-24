# ATK Collection Converter - Documentation

## Overview

ATK Collection Converter is a .NET 10 library that provides seamless conversion between various data collection types including `List<T>`, `DataFrame`, `DataTable`, and `TabularDataResource`. It also supports exporting data to Excel files.

## Project Information

- **Package Name**: ATK.Collection.Converter
- **Repository**: https://github.com/a-t-k/ATK.Collection.Converter
- **Framework**: .NET 10
- **License**: Check LICENSE file in repository

## Installation

Install via NuGet:
```
Install-Package ATK.Collection.Converter
```

## Core Features

- Convert `List<T>` to `DataFrame` or `DataTable`
- Convert `DataFrame` to other collection types
- Convert `DataTable` to `DataFrame` or `List<T>`
- Convert `TabularDataResource` to `DataFrame`
- Export `DataTable` and `DataSet` to Excel files

## Project Structure

### Main Components

#### ExtensionConverterWrapper
Provides extension methods for fluent conversion API:
- `Convert()` - Extension method for `TabularDataResource`, `List<T>`, `DataTable`

#### Converter Classes

**DataFrame Converters**
- `DataFrameConverter` - Base converter for DataFrame conversions

**DataTable Converters**
- `DataTableConverter` - Base converter for DataTable conversions
- `DataTableToDataFrameConverter` - Converts DataTable → DataFrame
- `DataTableToGenericListConverter` - Converts DataTable → List<T>

**List Converters**
- `ListConverter<T>` - Base converter for List conversions
- `ListToDataFrameConverter` - Converts List<T> → DataFrame
- `ListToDataTableConverter` - Converts List<T> → DataTable

**TabularDataResource Converters**
- `TabularDataResourceConverter` - Base converter for TabularDataResource
- `TabularDataResourceToDataFrameConverter` - Converts TabularDataResource → DataFrame

**Excel Support**
- `ExcelDocumentCreator` - Creates and exports data to Excel files

## Dependencies

- `DataView.InteractiveExtension` (v1.0.142)
- `DocumentFormat.OpenXml` (v3.5.1)
- `Microsoft.Data.Analysis` (v0.23.0)
- `Microsoft.DotNet.Interactive.Formatting` (v1.0.0-beta.26120.1)
- `Microsoft.ML` (v5.0.0)
- `SandDance.InteractiveExtension` (v1.0.142)

## Usage

### Basic Conversion Example

```csharp
using ATK.Collection.Converter;

// Convert List to DataFrame and DataTable
List<MyClass> myList = new();
var converters = myList.Convert();
var dataTable = converters.To.DataTable;
var dataFrame = converters.To.DataFrame;

// Convert DataTable to DataFrame
DataTable dt = new();
var result = dt.Convert().To.DataFrame;

// Convert TabularDataResource to DataFrame
TabularDataResource tdr = new();
var converted = tdr.Convert().To.DataFrame;
```

### Export to Excel

```csharp
var creator = new ExcelDocumentCreator();
creator.Save(dataTable, "output.xlsx");
```

## Testing

Test files are available in the `ATK.Collection.Converter.Tests` project:
- `DataTableTests` - DataTable conversion tests
- `ListToDataTableTests` - List to DataTable conversion tests
- `TabularDataResourceToDataFrameTest` - TabularDataResource conversion tests

## Target Platforms

- .NET 10.0

## Package Tags

`Excel`, `DataTable`, `TabularDataResource`, `DataFrame`, `List`

## Use Cases

- Polyglot notebooks data transformation
- Converting between different data representations
- Exporting tabular data to Excel
- Working with ML.NET DataFrames
- Interactive data analysis in .NET environments
