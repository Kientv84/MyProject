using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20110376_TruongChiKien_StudentManagement
{
    public static class GLOBAL
    {
        public static int GlobalUserId { get; private set; }
        public static void SetGlobalUserId(int userId)
        {
            GlobalUserId = userId;
        }
    }
}
