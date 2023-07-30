using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.BL;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.RegistrationForms;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.DL
{
    class AdminDL
    {
        private static List<Admin> AdminList = new List<Admin>();

        internal static List<Admin> AdminList1 { get => AdminList; set => AdminList = value; }

        public static void AddAdmin(Admin admin)
        {
            AdminList1.Add(admin);
        }
        public static void RemoveAdmin(Admin admin)
        {
            AdminList1.Remove(admin);
        }
        public static Admin SearchnReturnAdmin(string name)
        {
            foreach(Admin TempAdmin in AdminList1)
            {
                if(TempAdmin.Name==name)
                {
                    return TempAdmin;
                }
            }
            return null;
        }
        public static bool AdminIsAvailable(string name,string password)
        {
            foreach (Admin TempAdmin in AdminList1)
            {
                if (TempAdmin.Name == name && TempAdmin.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
