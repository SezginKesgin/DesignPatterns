﻿using DesignPattern.ChainOfResponsibility.DataAccessLayer;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
	public class AreaDirector : Employee
	{
		public override void ProcessRequest(CustomerProcessViewModel req)
		{
			Context context = new Context();
			if (req.Amount <= 400000)
			{
				CustomerProcess customerProcess = new CustomerProcess();
				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Bölge Direktörü - Zeynep Yılmaz";
				customerProcess.Description = "Para çekme işlemi onaylandı, Müşteriye talep edilen tutar ödendi.";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
			}
			else
			{
				CustomerProcess customerProcess = new CustomerProcess();
				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Bölge Direktörü - Zeynep Yılmaz";
				customerProcess.Description = "Para çekme tutarı Bölge Direktörünün günlük ödeyebileceği limiti aştığı için işlem gerçekleştirilemedi, Müşterinin günlük çekebileceği maksimum tutar 400.000tl olup daha fazlası için çekilecek tutarın farklı günlere yayılması gerekli...";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
			}
		}
	}
}
