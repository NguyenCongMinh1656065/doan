using QuanlyUser.Dto.Customers;
using QuanlyUser.Dto.Shared;
using QuanlyUser.Entities;

namespace QuanlyUser.Services.Interfaces
{
    public interface ICustomerService
    {
        void Create(CreateCustomerDto input);
        void Delete(int id);
        List<Customer> GetAll();
        PageResultDto<List<Customer>> GetAllWithPage(FilterDto input);
        Customer GetbyId(int id);
        void Update(UpdateCustomerDto input);
    }
}
