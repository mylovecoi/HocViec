using Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HocViec.Controllers.DanhMuc
{
    public class DanhMucLoaiHangController(IDanhMucLoaiHangService danhMucService) : ControllerBase
    {
        [HttpGet("DanhMucLoaiHang")]

        public async Task<IActionResult> GetAllDanhMucLoaiHang([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            try
            {
                var data = await danhMucService.GetAllDanhMucLoaiHangAsync();
                return Ok(data);
            }
            catch (Exception e)
            {
                //_logger.LogError(e, "An error occurred while processing the request.");
                return Ok(e.Message);
            }
        }
    }
}
