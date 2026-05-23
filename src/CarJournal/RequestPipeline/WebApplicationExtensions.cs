
using CarJournal.Jobs;

using Hangfire;

using Microsoft.EntityFrameworkCore;

public static class WebApplicationExtensions
{
    public static WebApplication IncludeDeveloperServices(
            this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        return app;
    }

    public static WebApplication SetupHangFire(this WebApplication app)
    {
        var options = new RecurringJobOptions
        {
            TimeZone = TimeZoneInfo.Local
        };

        app.UseHangfireDashboard();

        RecurringJob.AddOrUpdate<DailyMileageTrackingJob>(
            "mileage-tracking",
            job => job.ExecuteAsync(),
            "14 13 * * *",
            options
        );

        RecurringJob.AddOrUpdate<DailyDateTrackingJob>(
            "date-tracking",
            job => job.ExecuteAsync(),
            "10 15 * * *", //minute hour day month year
            options
        );

        return app;
    }

    public static WebApplication UseMigrations(this WebApplication app)
    {
        app.Services.CreateScope()
            .ServiceProvider.GetRequiredService<CarJournalDbContext>()
            .Database
            .Migrate();

        return app;
    }
}