# Universal Converter

A .NET 10 library for seamless conversion between various collection types: `List<T>`, `DataFrame`, `DataTable`, and `TabularDataResource`. Export data to Excel with ease.

## Features

- Converts `List<T>` to `DataFrame` or `DataTable`
- Converts `DataFrame` to other collection types
- Converts `DataTable` to `DataFrame` or `List<T>`
- Converts `TabularDataResource` to `DataFrame`
- Export `DataTable` and `DataSet` to Excel files
- Fluent API with extension methods
- Built for polyglot notebooks and interactive environments

## Installation

Install via NuGet:
```
Install-Package ATK.Collection.Converter
```

Or search for "ATK.Collection.Converter" in NuGet Package Manager.

## Quick Start

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

// Export to Excel
var creator = new ExcelDocumentCreator();
creator.Save(dataTable, "output.xlsx");
```

## Supported Conversions

| Source | Target |
|--------|--------|
| `List<T>` | `DataFrame`, `DataTable` |
| `DataFrame` | Other collection types |
| `DataTable` | `DataFrame`, `List<T>`, Excel |
| `TabularDataResource` | `DataFrame` |
| `DataSet` | Excel |

## Dependencies

- `DocumentFormat.OpenXml` (v3.5.1)
- `Microsoft.Data.Analysis` (v0.23.0)
- `SandDance.InteractiveExtension` (v1.0.142)

## Framework
- **.NET 10.0**

## Repository

https://github.com/a-t-k/

## Use Cases

- Polyglot notebooks data transformation
- Converting between different data representations
- Exporting tabular data to Excel
- Working with ML.NET DataFrames
- Interactive data analysis in .NET environments
