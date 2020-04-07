using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetExpenseByIdDto : BaseByIdDto
    {

    }
    public class GetExpenseByIdResultDto : BaseApiResult
    {
        public ExpenseDto Object { get; set; }
    }
}
