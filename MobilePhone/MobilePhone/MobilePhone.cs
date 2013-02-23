using System;

public class MobilePhone
{
    static void Main()
    {
        GSM phone = new GSM("3100", "Nokia", 120, "John Doe");

        phone.Battery.Model = "A1428";
        phone.Battery.HoursIdle = 10.5;
        phone.Battery.HoursTalk = 6;
        phone.Battery.BatteryType = Battery.BatteryTypes.LiIon;

        phone.Display.Size = 2;
        phone.Display.NumberOfColors = 16000;


        Console.WriteLine(phone);

        Console.WriteLine(GSM.IPhone4S);

        phone.AddCallsInHistory(new DateTime(23, 02, 2013, 11, 11, 11), "0888888999", 421);

        foreach (var item in phone.CallHistory)
        {
            Console.WriteLine(item);
        }
    }
}