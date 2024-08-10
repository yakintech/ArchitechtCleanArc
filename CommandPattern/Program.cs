

using CommandPattern.Models;

TextEditor textEditor = new TextEditor();
CommandManager commandManager = new CommandManager();


//write operation
var writeCommand = new WriteCommand(textEditor, "Hello World");
commandManager.ExecuteCommand(writeCommand);

var writeCommand2 = new WriteCommand(textEditor, "Hello World 2");
commandManager.ExecuteCommand(writeCommand2);

//erase operation
commandManager.Undo();


Console.ReadLine();