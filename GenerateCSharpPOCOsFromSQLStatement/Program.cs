// See https://aka.ms/new-console-template for more information
using GenerateCSharpPOCOsFromSQLStatement;
using Microsoft.Data.SqlClient;
using System.Data.Common;

// 連線字串
DbConnection _dbConnection = new SqlConnection(@"[ConnectionString]");

// 資料表名稱
var nameOfTableAndClass = "[ClassName]";

// 這邊修改為您要執行的 SQL Command
var sqlCommand = $@"SELECT [Columns] FROM [Table]";

// 在 DumpClass 方法裡放 SQL Command 和 Class 名稱
var value = _dbConnection.DumpClass(sqlCommand.ToString(), nameOfTableAndClass);

Console.WriteLine(value);
Console.WriteLine("Press enter to exit.");
Console.ReadLine();
