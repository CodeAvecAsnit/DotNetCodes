using Microsoft.EntityFrameworkCore;
using RelationsTest.Model;

namespace RelationsTest.Service;

public class CitizenService(AppDbContext _context)
{

    public List<Citizen> GetAll()
    {
        return _context.Citizens.ToList();
    }

    public Citizen? GetById(long id)
    {
        return _context.Citizens.Find(id);
    }

    public bool Insert(Citizen citizen)
    {
        try
        {
            _context.Citizens.Add(citizen);
            _context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool Update(Citizen updated)
    {
        var existing = GetById(updated.citizenId);
        if (existing == null)
            return false;

        existing.citzenName = updated.citzenName;
        _context.SaveChanges();
        return true;
    }

    public bool Delete(long id)
    {
        var citizen = _context.Citizens.Find(id);
        if (citizen == null) return false;
        var passport = _context.Passports.FirstOrDefault(p => p.citizenId == id);
        if (passport != null)
        {
            _context.Passports.Remove(passport);
        }

        _context.Citizens.Remove(citizen);
        _context.SaveChanges();
        return true;
    }

    public Passport? GetPassportForCitizen(long id)
    {
        return _context.Passports
            .FirstOrDefault(p => p.citizenId == id);
    }
}