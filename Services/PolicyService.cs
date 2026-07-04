using System;
using System.Threading.Tasks;

public class PolicyService
{
    private readonly ApplicationDbContext _dbContext;

    public PolicyService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Policy> CreatePolicyAsync(Policy request)
    {
        // โค้ดเดิมไม่มีการตรวจสอบ Business Rule เรื่องอายุรถ
        // ปล่อยผ่าน (Straight-through processing) ทุกกรณี
        
        request.Id = Guid.NewGuid();
        request.CreatedAt = DateTime.UtcNow;

        _dbContext.Policies.Add(request);
        await _dbContext.SaveChangesAsync();

        return request;
    }
}