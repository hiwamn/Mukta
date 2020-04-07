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
    public class OrderController : SimpleController
    {
        private readonly IAddOrder addOrder;
        private readonly IGetOrdersByPage getOrdersByPage;
        private readonly IGetOrderById getOrderById;
        private readonly IEditOrder editOrder;

        public OrderController(
            IAddOrder addOrder,
            IGetOrdersByPage getOrdersByPage,
            IGetOrderById getOrderById,
            IEditOrder editOrder
            )
        {
            this.addOrder = addOrder;
            this.getOrdersByPage = getOrdersByPage;
            this.getOrderById = getOrderById;
            this.editOrder = editOrder;
        }

        [HttpPost]
        public ActionResult<ApiResult> AddOrder([FromBody]AddOrderDto dto)
        {
            return addOrder.Execute(dto);
        }
        [HttpPost]
        public ActionResult<ApiResult> EditOrder([FromBody]EditOrderDto dto)
        {
            return editOrder.Execute(dto);
        }

        [HttpGet]
        public ActionResult<GetOrdersByPageResultDto> GetOrdersByPage([FromQuery]GetOrdersByPageDto dto)
        {
            return getOrdersByPage.Execute(dto);
        }
        [HttpGet]
        public ActionResult<GetOrderByIdResultDto> GetOrderById([FromQuery]GetOrderByIdDto dto)
        {
            return getOrderById.Execute(dto);
        }



    }
}
