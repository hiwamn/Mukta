using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetExpensesByPageDto : BaseByUserPageDto
    {

    }
    public class GetExpensesByPageResultDto : BaseApiPageResult
    {
        public List<ExpenseDto> Object { get; set; }
    }
}
