namespace SPLibrary
{
    public static class Writer
    {
        public static bool WriteListToTxt<T>(List<T> list, string fileName) where T : IContainer
        {
            if (list.Count > 0)
            {
                string path = @"..\..\..\Data\" + fileName;

                using StreamWriter writer = new StreamWriter(path);
                foreach (IContainer item in list)
                {
                    writer.WriteLine(item.ToString());
                }
                return true;
            }
            else return false;
        }
    }
}
