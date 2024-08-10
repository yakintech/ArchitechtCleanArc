
using MediatorPattern.Models;

Mediator chatRoom = new ChatRoomMediator();


Participant user1 = new User(chatRoom, "User1");
Participant user2 = new User(chatRoom, "User2");
Participant user3 = new User(chatRoom, "User3");


chatRoom.Register(user1);
chatRoom.Register(user2);
chatRoom.Register(user3);


user1.Send("User2", "Hello User2");
user2.Send("User1", "Hello User1");


Console.ReadLine();