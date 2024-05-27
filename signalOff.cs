using System;
using System.IO.Ports; 


public class CPHInline
{
    public string portName = "COM5"; // Change this to the port your Arduino is connected to
    public int baudRate = 9600;
	
	public bool Execute()
	{
        SerialPort serialPort = new SerialPort(portName, baudRate);
        serialPort.Open();
        serialPort.WriteLine("2"); 
        return true;
	}
}
