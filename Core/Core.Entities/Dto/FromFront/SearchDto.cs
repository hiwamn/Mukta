using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class SearchDto
    {
        public Guid? UserId { get; set; }        
        public string Keyword{ get; set; }        
    }
    public class SearchResultDto : BaseApiResult
    {
        public SearchObject Object { get; set; }
    }
    public class SearchObject
    {
        public List<FixedDto> Expense { get; set; }
        public List<FixedDto> Feedback { get; set; }
        public List<FixedDto> Lead { get; set; }
        public List<FixedDto> Order { get; set; }
        public List<FixedDto> Party { get; set; }
    }

    public class FixedDto
    {
        public Guid Id { get; set; }
        public string  Title{ get; set; }
        public string  Description{ get; set; }
        public string Name { get; set; }
    }
}
