using Microsoft.EntityFrameworkCore;
using Utility.CalendarHelper;

namespace PunishmentOrg.DataAccess.Repositories.BaseInfo.Anu.BaseInfo.FrontEndSecurity
{
    public class GFESUserAccessRepository : GenericRepository<DataModel.BaseInfo.Anu.BaseInfo.FrontEndSecurity.GFESUserAccess>, Domain.Interface.BaseInfo.Anu.BaseInfo.FrontEndSecurity.IGFESUserAccessRepository
    {
        public GFESUserAccessRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<DataModel.BaseInfo.Anu.BaseInfo.FrontEndSecurity.GFESUserAccess>> ValidateUserAndPassword(string userName, string hashedPassword, string GFESUserAccessType)
        {

            return await _context.Set<DataModel.BaseInfo.Anu.BaseInfo.FrontEndSecurity.GFESUserAccess>()
                .Include(a => a.TheGFESUser)
                .Include(a => a.TheGFESUserAccessType)
                .Where(a =>
                    a.TheGFESUser.UserID == userName.Trim() &&
                    a.TheGFESUser.Password == hashedPassword &&
                    a.TheGFESUser.EndDate.ToDateTime() >= CalendarHelper.DateTimeNow() &&
                    a.TheGFESUser.StartDate.ToDateTime() <= CalendarHelper.DateTimeNow() &&
                    a.ToDateTime.ToDateTime() >= CalendarHelper.DateTimeNow() &&
                    a.FromDateTime.ToDateTime() <= CalendarHelper.DateTimeNow() &&
                    a.TheGFESUserAccessType.Id == GFESUserAccessType
                    ).ToListAsync();
        }
    }
}
