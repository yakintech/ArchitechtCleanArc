

using SingletonPattern.Models;

DbHelper dbHelper = DbHelper.GetInstance("connection-1");
dbHelper.Status = "Status";

DbHelper dbHelper2 = DbHelper.GetInstance("connection-2");
dbHelper2.Status = "Status-2";


Console.WriteLine(dbHelper.ConnectionString);
Console.WriteLine(dbHelper.Status);

Console.WriteLine(dbHelper2.ConnectionString);
Console.WriteLine(dbHelper2.Status);


Console.ReadLine();