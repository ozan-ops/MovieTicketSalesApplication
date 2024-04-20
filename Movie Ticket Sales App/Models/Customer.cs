#pragma warning disable CS8604

namespace Movie_Ticket_Sales_App.Models
{
    public partial class Customer
    {
        public int id { get; set; }
        public int sessionID { get; set; }
        public string? customerName { get; set; }
        public string? customerSurname { get; set; }
        public string? customerIDNumber { get; set; }
        public string? cardNumber { get; set; }
        public int validityMonth { get; set; }
        public int validityYear { get; set; }
        public int securityCode { get; set; }

        public static bool control()
        {
            if (Program.homePage.datasSessions.SelectedRows.Count == 0 || Program.homePage.customerNameTxt.Text == string.Empty || Program.homePage.customerSurnameTxt.Text == string.Empty || Program.homePage.customerIDNumberTxt.Text == string.Empty || Program.homePage.cardNumberTxt.Text == "               " || Program.homePage.validityMonthCombo.SelectedItem == null || Program.homePage.validityYearCombo.SelectedItem == null || Program.homePage.securityCodeTxt.Text == string.Empty)
                return false;

            else
            {
                if (Program.homePage.customerIDNumberTxt.Text.Length != 11 || Program.homePage.cardNumberTxt.Text.Length != 19 || Program.homePage.securityCodeTxt.Text.Length != 3)
                    return false;

                if (int.Parse(Program.homePage.validityYearCombo.SelectedItem.ToString()) == DateTime.Today.Year)
                    if (int.Parse(Program.homePage.validityMonthCombo.SelectedItem.ToString()) < DateTime.Today.Month)
                        return false;
            }

            return true;
        }

        public static void clear()
        {
            Program.homePage.customerNameTxt.Text = string.Empty;
            Program.homePage.customerSurnameTxt.Text = string.Empty;
            Program.homePage.customerIDNumberTxt.Text = string.Empty;
            Program.homePage.cardNumberTxt.Text = string.Empty;
            Program.homePage.validityMonthCombo.SelectedItem = null;
            Program.homePage.validityYearCombo.SelectedItem = null;
            Program.homePage.securityCodeTxt.Text = string.Empty;
        }

        public static void saveDatas(Customer customer)
        {
            if (Program.existsDB())
            {
                try
                {
                    using (DBContext context = new DBContext())
                    {
                        context.Customers.Add(customer);
                        context.Sessions.Remove(new Session { id = customer.sessionID });
                        context.SaveChanges();
                        MessageBox.Show("Datas Saved", "Data Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Session.listDatas();
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
                        Program.homePage.datasSessions.DataSource = sessions;
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void fillValidityMonthCombo()
        {
            for (int i = 1; i < 13; i++)
            {
                Program.homePage.validityMonthCombo.Items.Add(i);
            }
        }
        public static void fillValidityYearCombo()
        {
            int years = DateTime.Today.Year;

            for (int i = 0; i < 5; i++)
            {
                Program.homePage.validityYearCombo.Items.Add(years + i);
            }
        }
    }
}
