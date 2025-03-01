using AutoMapper;
using Core.Services.Interfaces;
using Infrastructure.Models.DanhMuc;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Implements
{
    public class DanhMucLoaiHangService (IMapper mapper, IRepository<DanhMucLoaiHang> danhMucRepo) : IDanhMucLoaiHangService
    {
        public async Task<List<DanhMucLoaiHang>> GetAllDanhMucLoaiHangAsync()
        {
            var data = await danhMucRepo.GetAllAsync();
            return data.ToList();
        }
    }
}
