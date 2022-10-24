using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{

    static internal class Program
    {
        static void Main(string[] args)
        {
            MangaSeries JJK = new MangaSeries("Jujutsu Kaisen", "Gege Akutami", "Gege Akutami");
            MangaSeries BST = new MangaSeries("Beastars", "Itadaki Paru", "Itadaki Paru");
            IAnimeFan thomas = new HardcoreReader(BST);
            IAnimeFan becca = new CasualReader(JJK);

            ReadGBE(becca);
            ReadGBE(thomas);
        }

        static void ReadGBE(object obj)
        {
            if (obj is CasualReader)
            {
                MangaReader reader = (MangaReader)obj;
                reader.ReadManga();
                reader.WatchAnime();
                reader.RecommendManga();
            }
            if (obj is HardcoreReader)
            {
                HardcoreReader reader = (HardcoreReader)obj;
                reader.ReadManga();
                reader.WatchAnime();
                reader.RecommendManga();
            }
        }
    }

    public interface IAnimeFan
    {
        void WatchAnime();
    }

    public abstract class MangaReader : IAnimeFan
    {
        private List<IManga> readList;
        private IManga favManga;

        public List<IManga> ReadList { get; set; }
        public IManga FavManga { get; set; }
        public abstract void ReadManga();
        public virtual void RecommendManga() { Console.WriteLine("Somebody tells you to read the manga for this series"); }

        public MangaReader(IManga firstManga) { }

        public abstract void WatchAnime();
    }

    public class CasualReader : MangaReader
    {
        public override void ReadManga() { Console.WriteLine("Somebody read a chapter of Manga"); }
        public override void WatchAnime() { Console.WriteLine("Somebody watched an episode of Anime"); }

        public CasualReader(IManga fm) : base(fm) { }
    }

    public class HardcoreReader : MangaReader
    {
        public override void ReadManga() { Console.WriteLine("Some lunatic binged an entire Manga in one night"); }
        public override void RecommendManga() { Console.WriteLine("Some annoying person wont shut up about this series"); }
        public override void WatchAnime() { Console.WriteLine("Some idiot binged an entire Anime in one night"); }

        public HardcoreReader(IManga fm) : base(fm) { }
    }

    public interface IManga
    {
        void ReleaseChapter();
        void ReleaseBook();
    }

    public abstract class Manga
    {
        public string title;
        public string author;
        public string artist;

        public Manga(string title, string author, string artist)
        {
            this.title = title;
            this.author = author;
            this.artist = artist;
        }
    }

    public class MangaSeries : Manga, IManga
    {
        public List<MangaChapter> chapters;
        public bool finished;

        public void ReleaseChapter() { }

        public void ReleaseBook() { }

        public MangaSeries(string t, string auth, string art) : base(t, auth, art) { }
    }

    public class Oneshot : Manga, IManga
    {
        public static MangaChapter chapter;

        public void ReleaseChapter() { }

        public void ReleaseBook() { }

        public Oneshot(string t, string auth, string art) : base(t, auth, art) { }
    }

    public class MangaChapter
    {
        public IManga series;
        public int pages;
    }
}
