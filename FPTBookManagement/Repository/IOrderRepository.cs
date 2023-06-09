﻿using FPTBookManagement.Models;

namespace FPTBookManagement.Repository
{
	public interface IOrderRepository
	{
		IQueryable<Order> Orders { get; }
		void SaveOrder(Order order);
	}
}
