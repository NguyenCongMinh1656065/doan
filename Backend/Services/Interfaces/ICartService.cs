﻿using QuanlyUser.Dto.Cart;
using QuanlyUser.Dto.Shared;
using QuanlyUser.Entities;

namespace QuanlyUser.Services.Interfaces
{
    public interface ICartService
    {
        void Create(CreateCartDto input);
        void Delete(int id);

        void DeleteAll(int id);
        void DeleteAllFull();
        List<Cart> GetAll();
        PageResultDto<List<Cart>> GetAllWithPage(FilterDto input);
        Cart GetbyId(int id);
    }
}
