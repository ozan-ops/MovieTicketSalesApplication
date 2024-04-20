#pragma warning disable CS8602, CS8604

namespace Movie_Ticket_Sales_App.Models
{
    public partial class Session
    {
        public int id { get; set; }
        public string? movieName { get; set; }
        public string? movieTheaterName { get; set; }
        public DateTime movieDate {  get; set; }
        public TimeSpan movieTime { get; set; }

        public static bool control()
        {
            if (Program.homePage.sMovieNameCombo.SelectedItem == null || Program.homePage.sMovieTheaterNameCombo.SelectedItem == null || Program.homePage.sMovieTimeCombo.SelectedItem == null)
                return false;

            else
                if (Program.homePage.sMovieDateDt.Value < DateTime.Today)
                    return false;

            return true;
        }

        public static void clear()
        {
            Program.homePage.sMovieNameCombo.SelectedItem = null;
            Program.homePage.sMovieTheaterNameCombo.SelectedItem = null;
            Program.homePage.sMovieDateDt.Value = DateTime.Today;
            Program.homePage.sMovieTimeCombo.SelectedItem = null;
            Program.homePage.sMovieTimeCombo.Items.Clear();
        }

        public static void saveDatas(Session session)
        {
            if (Program.existsDB())
            {
                try
                {
                    using (DBContext context = new DBContext())
                    {
                        MovieTheater? movieTheater = context.MovieTheaters.FirstOrDefault(s => s.movieTheaterName == session.movieTheaterName);
                        movieTheater.movieTheaterCapacity--;

                        context.Sessions.Add(session);
                        context.SaveChanges();
                        MessageBox.Show("Datas Saved", "Data Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Customer.listDatas();
                        listDatas();
                        clear();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void listDatas()
        {
            if (Program.existsDB())
            {
                try
                {
                    using (DBContext context = new DBContext())
                    {
                        List<Session> sessions = context.Sessions.ToList();
                        Program.homePage.datasSession.DataSource = sessions;
                    }

                    fillMovie();
                    fillMovieTheaters();

                    MovieTheater.listDatas();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void fillMovie()
        {
            if (Program.existsDB())
            {
                try
                {
                    using (DBContext context = new DBContext())
                    {
                        Program.homePage.sMovieNameCombo.Items.Clear();
                        List<string?> movies = context.Movies.Select(f => f.movieName).ToList();
                        foreach (string? item in movies)
                        {
                            Program.homePage.sMovieNameCombo.Items.Add(item);
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void fillMovieTheaters()
        {
            if (Program.existsDB())
            {
                try
                {
                    using (DBContext context = new DBContext())
                    {
                        Program.homePage.sMovieTheaterNameCombo.Items.Clear();
                        List<string?> movieTheaters = context.MovieTheaters.Where(f => f.movieTheaterCapacity > 0).Select(f => f.movieTheaterName).ToList();
                        foreach (string? item in movieTheaters)
                        {
                            Program.homePage.sMovieTheaterNameCombo.Items.Add(item);
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void fillMovieTimes()
        {
            if (Program.existsDB() && Program.homePage.sMovieNameCombo.SelectedItem != null)
            {
                try
                {
                    using (DBContext context = new DBContext())
                    {
                        var movieTimes = context.Movies.Where(f => f.movieName == Program.homePage.sMovieNameCombo.SelectedItem.ToString()).Select(f => new { f.timeOne, f.timeTwo, f.timeThree, f.timeFour }).FirstOrDefault();

                        if (movieTimes != null)
                        {
                            Program.homePage.sMovieTimeCombo.Items.Clear();
                            Program.homePage.sMovieTimeCombo.Items.Add(movieTimes.timeOne.ToString());
                            Program.homePage.sMovieTimeCombo.Items.Add(movieTimes.timeTwo.ToString());
                            Program.homePage.sMovieTimeCombo.Items.Add(movieTimes.timeThree.ToString());
                            Program.homePage.sMovieTimeCombo.Items.Add(movieTimes.timeFour.ToString());
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void fillSMovieDateDt()
        {
            Program.homePage.sMovieDateDt.Value = DateTime.Today;
        }
    }
}
