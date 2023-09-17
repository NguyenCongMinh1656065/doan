using QuanlyUser.Dto.Customers;
using QuanlyUser.Dto.Shared;
using QuanlyUser.Entities;

namespace QuanlyUser.Services.Interfaces
{
    public interface IOrderService
    {
        void Create(CreateOrderDto input);
        void Delete(int id);
        void DeleteAllFull();
        List<Order> GetAll();
        PageResultDto<List<Order>> GetAllWithPage(FilterDto input);
    }
}
