﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtoCommerce.Domain.Commerce.Model.Search;
using VirtoCommerce.Domain.Order.Model;

namespace VirtoCommerce.Domain.Order.Services
{
	public interface ICustomerOrderSearchService
	{
        GenericSearchResult<CustomerOrder> SearchCustomerOrders(CustomerOrderSearchCriteria criteria);
	}
}
