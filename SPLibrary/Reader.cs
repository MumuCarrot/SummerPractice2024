namespace SPLibrary
{
    public static class Reader
    {
        public static List<string> Read(string fileName)
        {
            try
            {
                string path = @"..\..\..\Data\" + fileName;

                string[] lines = File.ReadAllLines(path);

                return new List<string>(lines);
            }
            catch (Exception ex)
            {
                throw new Exception("Reader error: " + ex.Message);
            }
        }
    }
}
