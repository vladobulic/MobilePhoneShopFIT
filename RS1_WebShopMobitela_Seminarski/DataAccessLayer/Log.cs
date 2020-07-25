using DataAccessLayer;
using System;
public class Log : BaseEntity{
	 
	public DateTime TimeStamp;
	public string RequestId;
	public string Message;
	public string Type;
	public string Source;
	public string StackTrace;
	public string RequestPath;
	public string User;
	public string ActionDescriptor;
	public string IpAddress;

}
