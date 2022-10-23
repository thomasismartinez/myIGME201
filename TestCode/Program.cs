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
            Oneshot GBE = new Oneshot("Good-bye Eri", "Fujimoto Tatsuki", "Fujimoto Tatsuki");
            MangaSeries JJK = new MangaSeries("Jujutsu Kaisen", "Gege Akutami", "Gege Akutami");
            MangaSeries BST = new MangaSeries("Beastars", "Itadaki Paru", "Itadaki Paru");
            HardcoreReader thomas = new HardcoreReader(BST);
            CasualReader becca = new CasualReader(JJK);

            MyMethod(thomas);
            MyMethod(becca);
        }

        static void MyMethod(object obj)
        {

            if ((Type)obj == typeof(HardcoreReader))
            {

            }
            if ((Type)obj == typeof(CasualReader))
            {

            }
        }
    }

    public interface IAnimeFan
    {
        void WatchAnime();
    }

    public abstract class MangaReader
    {
        private List<IManga> readList;
        private IManga favManga;

        public List<IManga> ReadList { get; set; }
        public IManga FavManga { get; set; }
        public abstract void ReadManga();
        public virtual void RecommendManga() { }

        public MangaReader(IManga firstManga) { }
    }

    public class CasualReader : MangaReader, IAnimeFan
    {
        public override void ReadManga() { }
        public void WatchAnime() { }

        public CasualReader(IManga fm) : base(fm) { }
    }

    public class HardcoreReader : MangaReader, IAnimeFan
    {
        public override void ReadManga() { }
        public override void RecommendManga() { }
        public void WatchAnime() { }

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
