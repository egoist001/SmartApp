using Log_Reg_Form.Roles;
using Log_Reg_Form.Vizualizer;
using System;

namespace Log_Reg_Form
{
    internal class XMLVizualizer : IVisualizer
    {
        private string _user;
        private LogStatus _action;

        public XMLVizualizer(string user, LogStatus action)
        {
            _user = user;
            _action = action;
        }

        public string Visualize()
        {
            return string.Format("<log>\n\t<user>{0}</user>\n\t<action>{1}</action>\n\t<time>{2}</time>\n</log>\n", _user, _action, DateTime.Now);
            
        }
    }
}