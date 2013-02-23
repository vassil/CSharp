using System;
using System.Text;
using System.Collections.Generic;

public class GSM
{
    private static GSM iPhone4S;
    public static GSM IPhone4S 
    {
        get 
        {
            iPhone4S = new GSM("4S", "Apple", 600, "Jane Doe");
            iPhone4S.Battery.Model = "A1428";
            iPhone4S.Battery.HoursIdle = 200;
            iPhone4S.Battery.HoursTalk = 14;
            iPhone4S.Battery.BatteryType = Battery.BatteryTypes.LiPo;

            iPhone4S.Display.Size = 3.5;
            iPhone4S.Display.NumberOfColors = 16000000;

            return iPhone4S;
        }
    }

    private string model;
    private string manufactorer;
    private double? price;
    private string owner;
    private List<Call> callHistory;

    public GSM(string model, string manufacturer) : this(model, manufacturer, null, null)
    {
    }

    public GSM(string model, string manufacturer, double? price, string owner) 
    {
        this.Model = model;
        this.Manufactorer = manufacturer;
        this.Price = price;
        this.Owner = owner;
    }

    public string Owner
    {
        get
        {
            return this.owner;
        }
        set
        {
            this.owner = value;
        }
    }

    public double? Price
    {
        get
        {
            return this.price;
        }
        set 
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException("Price must be bigger than 0.");
            }
            else
            {
                this.price = value;
            }
        }
    }

    public string Manufactorer
    {
        get
        {
            return this.manufactorer;
        }
        set 
        {
            if (String.IsNullOrEmpty(this.manufactorer) || String.IsNullOrWhiteSpace(this.manufactorer))
            {
                this.manufactorer = value; 
            }
            else
            {
                throw new FormatException("Enter a Manufactorer.");
            }
        }
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (String.IsNullOrEmpty(this.model) || String.IsNullOrWhiteSpace(this.model))
            {
                this.model = value;
            }
            else
            {
                throw new FormatException("Enter a Model.");
            }
        }
    }

    public List<Call> CallHistory 
    {
        get { return callHistory; }
    }

    public Display Display = new Display();

    public Battery Battery = new Battery();

    public override string ToString()
    {
        StringBuilder allInfo = new StringBuilder();
        allInfo.AppendFormat("Phone model - {0} \r\n", this.model);
        allInfo.AppendFormat("Phone manufactorer - {0} \r\n", this.manufactorer);
        allInfo.AppendFormat("Phone price - {0}lv \r\n", this.price);
        allInfo.AppendFormat("Phone owner - {0} \r\n", this.owner);
        allInfo.AppendFormat("Display size - {0}' \r\n", Display.Size);
        allInfo.AppendFormat("Display colors - {0} \r\n", Display.NumberOfColors);
        allInfo.AppendFormat("Battery model - {0} \r\n", Battery.Model);
        allInfo.AppendFormat("Battery type - {0} \r\n", Battery.BatteryType);
        allInfo.AppendFormat("Battery idle hours - {0}h \r\n", Battery.HoursIdle);
        allInfo.AppendFormat("Battery talk hours - {0}h \r\n", Battery.HoursTalk);

        return allInfo.ToString();
    }

    public void AddCallsInHistory(DateTime dateAndTime, string dialedNumber, int duration)
    {
        //new DateTime(23, 02, 2013, 11, 11, 11), "0888888999", 421
        Call call = new Call(dateAndTime, dialedNumber, duration);

        callHistory.Add(call);
    }

    public void RemoveCallsFromHistory(int callIndex)
    {
        callHistory.RemoveAt(callIndex);
    }

    public void ClearCallsHistory()
    {
        callHistory.Clear();
    }
}