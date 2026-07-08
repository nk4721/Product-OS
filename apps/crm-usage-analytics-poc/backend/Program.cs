var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy => policy
        .AllowAnyHeader()
        .AllowAnyMethod()
        .WithOrigins("http://localhost:5173"));
});

var app = builder.Build();

app.UseCors();

var users = DemoData.Users;

app.MapGet("/", () => Results.Redirect("/api/usage/summary"));

app.MapGet("/api/usage/summary", () =>
{
    var activeUsers = users.Count(x => x.IsActive);
    var inactiveUsers = users.Count - activeUsers;
    var adoptionScore = users.Count == 0 ? 0 : Math.Round(users.Average(x => x.AdoptionScore), 1);

    return new
    {
        adoptionScore,
        weeklyActiveUsers = activeUsers,
        monthlyActiveUsers = users.Count(x => x.LastLogin >= DateTime.UtcNow.AddDays(-30)),
        inactiveUsers,
        averageActivitiesPerUser = Math.Round(users.Average(x => x.ActivitiesLogged), 1),
        topTeam = users.GroupBy(x => x.Team)
            .Select(g => new { team = g.Key, score = Math.Round(g.Average(x => x.AdoptionScore), 1) })
            .OrderByDescending(x => x.score)
            .FirstOrDefault()
    };
});

app.MapGet("/api/usage/users", () => users.OrderByDescending(x => x.AdoptionScore));

app.MapGet("/api/usage/teams", () => users
    .GroupBy(x => x.Team)
    .Select(g => new
    {
        team = g.Key,
        users = g.Count(),
        activeUsers = g.Count(x => x.IsActive),
        adoptionScore = Math.Round(g.Average(x => x.AdoptionScore), 1),
        activitiesLogged = g.Sum(x => x.ActivitiesLogged),
        opportunitiesUpdated = g.Sum(x => x.OpportunitiesUpdated),
        companiesUpdated = g.Sum(x => x.CompaniesUpdated)
    })
    .OrderByDescending(x => x.adoptionScore));

app.Run();

public record UserUsage(
    string User,
    string Team,
    DateTime LastLogin,
    int ActivitiesLogged,
    int OpportunitiesUpdated,
    int CompaniesUpdated,
    int ContactsUpdated,
    int EmailsLogged,
    int NotesCreated)
{
    public bool IsActive => LastLogin >= DateTime.UtcNow.AddDays(-7);

    public double AdoptionScore
    {
        get
        {
            var loginScore = IsActive ? 20 : LastLogin >= DateTime.UtcNow.AddDays(-30) ? 10 : 0;
            var activityScore = Math.Min(ActivitiesLogged * 2, 20);
            var opportunityScore = Math.Min(OpportunitiesUpdated * 4, 20);
            var companyScore = Math.Min(CompaniesUpdated * 3, 15);
            var contactScore = Math.Min(ContactsUpdated * 2, 10);
            var emailScore = Math.Min(EmailsLogged, 10);
            var noteScore = Math.Min(NotesCreated, 5);
            return loginScore + activityScore + opportunityScore + companyScore + contactScore + emailScore + noteScore;
        }
    }
}

public static class DemoData
{
    public static readonly List<UserUsage> Users = new()
    {
        new("Anna Berg", "Sales Sweden", DateTime.UtcNow.AddDays(-1), 24, 6, 5, 9, 18, 4),
        new("Johan Nilsson", "Sales Sweden", DateTime.UtcNow.AddDays(-2), 19, 5, 3, 7, 12, 3),
        new("Lisa Andersson", "Marketing", DateTime.UtcNow.AddDays(-18), 3, 0, 1, 2, 1, 1),
        new("Erik Svensson", "Support", DateTime.UtcNow.AddDays(-3), 16, 1, 7, 11, 8, 5),
        new("Maria Holm", "Management", DateTime.UtcNow.AddDays(-6), 9, 3, 2, 3, 5, 2),
        new("Karin Olsson", "Sales Denmark", DateTime.UtcNow.AddDays(-1), 21, 7, 4, 8, 15, 4),
        new("Peter Larsen", "Sales Denmark", DateTime.UtcNow.AddDays(-11), 7, 2, 1, 2, 4, 1),
        new("Oskar Lind", "Marketing", DateTime.UtcNow.AddDays(-42), 0, 0, 0, 0, 0, 0)
    };
}
