
using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetStoreCategoriesResultDto : BaseApiResult
    {
        public List<StoreCategoryDto> Object { get; set; }
    }


}
