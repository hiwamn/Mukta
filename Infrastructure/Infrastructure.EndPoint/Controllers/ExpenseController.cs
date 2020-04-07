using Core.ApplicationServices;
using Core.Entities.Dto;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.EndPoint.Controllers
{
    public class ExpenseController : SimpleController
    {
        private readonly IAddExpense addExpense;
        private readonly IGetExpensesByPage getExpensesByPage;
        private readonly IGetExpenseById getExpenseById;
        private readonly IEditExpense editExpense;

        public ExpenseController(
            IAddExpense addExpense,
            IGetExpensesByPage getExpensesByPage,
            IGetExpenseById getExpenseById,
            IEditExpense editExpense
            )
        {
            this.addExpense = addExpense;
            this.getExpensesByPage = getExpensesByPage;
            this.getExpenseById = getExpenseById;
            this.editExpense = editExpense;
        }
        [HttpPost]
        public ActionResult<ApiResult> AddExpense([FromBody]AddExpenseDto dto)
        {
            return addExpense.Execute(dto);
        }
        [HttpPost]
        public ActionResult<ApiResult> EditExpense([FromBody]EditExpenseDto dto)
        {
            return editExpense.Execute(dto);
        }
        [HttpGet]
        public ActionResult<GetExpenseByIdResultDto> GetExpenseById([FromQuery]GetExpenseByIdDto dto)
        {
            return getExpenseById.Execute(dto);
        }
        [HttpGet]
        public ActionResult<GetExpensesByPageResultDto> GetExpensesByPage([FromQuery]GetExpensesByPageDto dto)
        {
            return getExpensesByPage.Execute(dto);
        }



    }
}
