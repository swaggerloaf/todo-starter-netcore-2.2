# todo-starter-netcore-2.2

Todo starter app for .NET Core 2.2 using sqlite 3 database

<code>dotnet aspnet-codegenerator</code>
<code>dotnet ef migrations add InitialCreate</code>
<code>dotnet ef database update</code>
<code>sqlite3 todos.db</code>
<code>.tables</code>
<code>insert into users (id, name) values (1, "Fred");</code>
<code>insert into users (id, name) values (2, "Brian");</code>
<code>insert into users (id, name) values (3, "Tom");</code>
<code>insert into users (id, name) values (4, "Ed");</code>
<code>insert into todos (id, userid, text, iscompleted) values (1,1, "Call Brian", false);</code>
<code>insert into todos (id, userid, text, iscompleted) values (3,4, "Call Ed", false);</code>

<code>dotnet aspnet-codegenerator razorpage TodoList Empty -outDir Pages/Todos -udl</code>
