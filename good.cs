class Post
{
    Logger logger = new Logger();

    CreatePost(Database db, string postMessage)
    {
        try
        {
            db.Add(postMessage);
        }
        catch (Exception ex)
        {
            logger.error(ex.ToString());
        }
    }
}

class Logger
{
    error(string error)
    {
      db.LogError("An error occured: ", error);
      File.WriteAllText("./errors.txt", error);
    }
}