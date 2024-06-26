﻿using DesignPattern.ChainOfResponsibility.DataAccessLayer;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
	public class ManagerAssistant : Employee
	{
		public override void ProcessRequest(CustomerProcessViewModel req)
		{
			Context context = new Context();
			if (req.Amount <= 150000)
			{
				CustomerProcess customerProcess = new CustomerProcess();
				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Mehmet Öztürk";
				customerProcess.Description = "Para çekme işlemi onaylandı, Müşteriye talep edilen tutar ödendi.";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
			}
			else if (NextApprover != null)
			{
				CustomerProcess customerProcess = new CustomerProcess();
				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Mehmet Öztürk";
				customerProcess.Description = "Para çekme tutarı Şube Müdür Yardımcısının günlük ödeyebileceği limiti aştığı için işlem şube müdürüne yönlendirildi.";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
				NextApprover.ProcessRequest(req);
			}
		}
	}
}
