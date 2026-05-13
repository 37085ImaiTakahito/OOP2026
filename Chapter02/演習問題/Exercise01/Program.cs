

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            var songs = new List<Song>();

            Console.WriteLine("***** 曲の登録　*****");

            while (true) {
                Console.Write("曲名：");
                string? title = Console.ReadLine();

                if (title.Equals("end", StringComparison.OrdinalIgnoreCase))
                    break;

                Console.Write("アーティスト名：");
                string? artistname = Console.ReadLine();

                Console.Write("演奏時間（秒）：");
                int length = Console.Read();
                Console.ReadLine();

                Song song = new Song(title, artistname, length);


                songs.Add(song);
                Console.WriteLine();
            }



            //           var songs = new Song[] {
            //             new Song("Let it be", "The Beatles",243),
            //             new Song("Bridge Over Troubled Water","Simon & Garfunkel",293),
            //             new Song("Close To You","Carpenters",276),
            //             new Song("Honesrty","Billy joel",231),
            //             new Song("I Will Always Love You","Whitney Houston",273),
            //           };

            PrintSongs(songs);
        }

        private static void PrintSongs(IEnumerable<Song> songs) {

            foreach (var song in songs) {
                var miutes = song.Length / 60;
                var seconds = song.Length % 60;
                Console.WriteLine($"{song.Title},{song.ArtistName},{miutes}:{seconds:00}");
            }
        }


    }
}
