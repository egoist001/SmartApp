using Log_Reg_Form.Forms;


namespace Log_Reg_Form
{
    public static class Session
    {

        public static Main_Form Main_Form { get; set; }

        public static User User { get; set; }

        public static Dashboard Dashboard { get; set; }
        public static AdminPanel AdminPanel { get;  set; }
        public static UsersList ListForm { get; set; }
        public static LogsListForm LogsForm { get; set; }
        public static string Code { get; set; }

        public static void CloseApp()
        {
            Main_Form.Close();
        }
    }
}
