namespace handsNET.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private handsNETDbContext dbContext;

        public handsNETDbContext Init()
        {
            return dbContext ?? (dbContext = new handsNETDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}