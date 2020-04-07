using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class GetAdminSummaries : IGetAdminSummaries
    {
        private readonly IUnitOfWork unit;

        public GetAdminSummaries(
            IUnitOfWork unit
            )
        {
            this.unit = unit;
        }
        public GetAdminSummariesResultDto Execute(GetAdminSummariesDto dto)
        {
            return new GetAdminSummariesResultDto
            {
                Object = new Summary
                {
                    NewExpensesCount = unit.Expense.GetNewCount(),
                    NewFeedbacksCount = unit.Feedback.GetNewCount(),
                    NewLeadsCount = unit.Lead.GetNewCount(),
                    NewOrdersCount = unit.Order.GetNewCount(),
                    NewPartiesCount = unit.Party.GetNewCount(),
                    NewUsersCount = unit.User.GetNewCount(),
                    NewWaitingUsersCount = unit.User.GetWaitingUsersCount()
                },
                Status = true
            };
        }
    }

    
}
