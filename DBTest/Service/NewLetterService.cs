using DBTest.Models;

namespace DBTest.Service;

public class NewLetterService(AppDbContext app)
{
    public List<NewLetter> GetAll()
    {
            return app.NewLetters.ToList();
    }

    public NewLetter Search(int id)
    {
        var news = app.NewLetters.Find(id);
        if (news != null)
        {
            return news;
        }
        else throw new Exception($"{id} doesn't exist in the system");
    }
    
    public bool Insert(NewLetter newLetter)
    {
        try
        {
            app.NewLetters.Add(newLetter);
            app.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    
    public bool Delete(int id)
    {
        var newLetter = app.NewLetters.Find(id);
        if (newLetter != null)
        {
            app.NewLetters.Remove(newLetter);
            app.SaveChanges();
            return true;
        }
        else return false;
    }


    public bool Update(NewLetter newsLetter)
    {
        var existing = app.NewLetters.FirstOrDefault(letter => letter.newId == newsLetter.newId);
        if (existing != null)
        {
            existing.headline=newsLetter.headline;
            existing.date = newsLetter.headline;
            existing.body = newsLetter.date;
            existing.author = newsLetter.author;
            app.SaveChanges();
            return true;
        }
        else return false;
    }
}