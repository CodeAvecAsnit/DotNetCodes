using Microsoft.EntityFrameworkCore;
using RelationsTest.Model;

namespace RelationsTest.Service;

public class PassportService(AppDbContext app)
{
    public List<Passport> GetAll()
    {
        return app.Passports.
            Include(p => p.citizen).
            ToList();
    }

    public bool InsertPassport(Passport passport)
    {
        using var transaction = app.Database.BeginTransaction();
        try
        {
            var citizen = app.Citizens.Find(passport.citizenId);
            if (citizen == null && passport.citizen?.citzenName != null)
            {
                app.Citizens.Add(passport.citizen);
                app.SaveChanges();
                passport.citizenId = passport.citizen.citizenId;
            }

            app.Passports.Add(passport);
            app.SaveChanges();
            transaction.Commit();
            return true;

        }
        catch (Exception ex)
        {
            transaction.Rollback();
            throw new Exception(ex.Message);
        }
    }

    public Passport? Search(long passId)
    {
       return app.Passports.
           Include(c =>c.citizen).
           FirstOrDefault(p=>p.pId ==passId);
        
    }

    public bool Delete(long passId)
    {
        var passport = app.Passports.Find(passId);
        if (passport == null) return false;
        app.Passports.Remove(passport);
        app.SaveChanges();
        return true;
    }

    public bool Update(Passport updated)
    {
        var passport = app.Passports.Find(updated.pId);
        if (passport == null) return false;
        passport.IssueDate = updated.IssueDate;
        passport.ExpiryDate = updated.ExpiryDate;
        passport.citizenId = updated.citizenId;
        app.SaveChanges();
        return true;
    }

    public Citizen? GetCitizenInfo(Passport passport)
    {
        return app.Citizens.Find(passport.citizenId);

    }

    public Citizen? GetCitizenInfo(long id)
    {
        var pass = Search(id);
        return pass != null ? GetCitizenInfo(pass) : null;
    }
}