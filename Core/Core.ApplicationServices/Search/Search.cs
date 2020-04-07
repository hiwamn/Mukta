using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class Search : ISearch
    {

        private readonly IUnitOfWork unit;

        public Search(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public SearchResultDto Execute(SearchDto dto)
        {
            SearchResultDto result = new SearchResultDto { Status = true, Message = Messages.Success, };
            result.Object = new SearchObject
            {
                Expense = unit.Expense.Search(dto),
                Feedback = unit.Feedback.Search(dto),
                Lead = unit.Lead.Search(dto),
                Order = unit.Order.Search(dto),
                Party = unit.Party.Search(dto)
            };
            return result;
        }
    }
}
