using System.IO;

namespace Observers
{
    public class FileSaver : IObserver<AbstractStringSubject>
    {
        private readonly string filename;

        public FileSaver(string filename)
        {
            this.filename = filename;
        }

        public void Update(AbstractStringSubject sub)
        {
            string info = sub.Item;
            File.AppendAllText(filename, info + "\n");
        }
    }
}