

using BuilderPattern.Models;

PhoneBuilder phone = new HuaweiConcreteBuilder();

CreatePhone createPhone = new CreatePhone();
createPhone.Create(phone);

Console.WriteLine(phone.Phone.ToString());